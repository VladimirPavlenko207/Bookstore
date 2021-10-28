using Bookstore.Controls;
using Bookstore.Entities;
using Bookstore.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class CartForm : Form
    {
        private static CartForm _instance;
        /// <summary>
        /// Текущий клиент
        /// </summary>
        public static User CurrentUser { get; set; }
        private int CurrentHeight { get; set; } 
        private decimal TotalSum { get; set; }
        private CartForm()
        {
            InitializeComponent();
            labelError.Text = "Чтобы совершить покупку, необходимо авторизоваться!";
            SetButtonBuy();
        }

        private void SetButtonBuy()
        {
            labelError.Visible = !(buttonBuy.Enabled = CurrentUser is not null);
            buttonBuy.BackColor = buttonBuy.Enabled ? Color.Green : Color.Red;
            buttonBuy.Enabled = TotalSum > 0;
        }

        public static CartForm GetInstance(User user)
        {
            CurrentUser = user;
            return _instance ??= new();
        }

        /// <summary>
        /// Метод добавляет книгу и ее конечную цену в заказ
        /// </summary>
        /// <param name="book"></param>
        /// <param name="promPrice"></param>
        public void AddBookControl(Book book, decimal promPrice)
        {
            if (IsBookIdExists(book.Id)) return;

            var bookInCart = new BookInCart(book, promPrice);
            panelMain.Controls.Add(bookInCart);
            bookInCart.Top = CurrentHeight;
            CurrentHeight += bookInCart.Height;
            bookInCart.ControlDeletion += DeleteUserItem;
            bookInCart.CountChanged += SetTotalSum;
            SetTotalSum();
        }

        private void SetTotalSum()
        {
            TotalSum = 0;
            foreach (BookInCart item in panelMain.Controls)
            {
                TotalSum += item.GetSum();
            }
            labelTotalSum2.Text = $"{TotalSum} грн.";
            buttonBuy.Enabled = TotalSum > 0;
        }

        private bool IsBookIdExists(int id)
        {
            foreach (BookInCart item in panelMain.Controls)
            {
                if (item.Book.Id == id)
                {
                    item.BookCountIncrement();
                    return true;
                }
            }
            return false;
        }

        private void CartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        /// <summary>
        /// Метод удаляет из заказа выбранную книгу
        /// </summary>
        /// <param name="bookInCart"></param>
        public void DeleteUserItem(BookInCart bookInCart)
        {
            var items = panelMain.Controls;
            foreach (BookInCart item in items)
            {
                if (bookInCart == item)
                {
                    items.Remove(item);
                    break;
                }
            }
            CurrentHeight = 0;
            foreach (BookInCart item in items)
            {
                item.Top = CurrentHeight;
                CurrentHeight += item.Height;
            }
            SetTotalSum();
        }

        private void CartForm_Activated(object sender, EventArgs e)
        {
            SetButtonBuy();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            MakeASaleAsync();
            SetButtonBuy();
        }

        private async void MakeASaleAsync()
        {
            using BookStoreContext context = new();
            var order = new Order();
            order.PurchaseDate = DateTime.Now;
            order.OrderItems = await Task.Run(() => NewOrderItems(context));
            if (MessageBox.Show(CreateMessage(order), "Спасибо за покупку!",
                MessageBoxButtons.OKCancel) != DialogResult.OK) return;

            await Task.Run(() =>
            {
                order.User = context.Users.FirstOrDefault(u => u == CurrentUser);
                context.Orders.Add(order);
                context.SaveChanges();
            });
            ClearForm();
        }

        private void ClearForm()
        {
            panelMain.Controls.Clear();
            labelTotalSum2.Text = "0";
            TotalSum = 0;
            CurrentHeight = 0;
        }

        private string CreateMessage(Order order)
        {
            string orderItemsStr = string.Empty;
            decimal sum = 0;
            foreach (var item in order.OrderItems)
            {
                orderItemsStr += $" ▰ {item.Book.Title} - {item.Count}шт. - {item.Price * item.Count} грн.\n";
                sum += item.Price * item.Count;
            }

            string message = $"Ваш заказ:\n" +
                $"{orderItemsStr}\n" +
                $"Всего: {sum}грн.\n" +
                $"{order.PurchaseDate.ToLongDateString()}";

            return message;
        }

        private List<OrderItem> NewOrderItems(BookStoreContext context)
        {
            var orderItemList = new List<OrderItem>();
            foreach (BookInCart item in panelMain.Controls)
            {
                var oi = new OrderItem
                {
                    Book = context.Books.FirstOrDefault(b => b == item.Book),
                    Count = item.BookCount,
                    Price = item.PromPrice
                };
                oi.Book.AvailableCount-= item.BookCount;
                oi.Book.SoldCount += item.BookCount;
                orderItemList.Add(oi);
            }
            return orderItemList;
        }

    }
}
