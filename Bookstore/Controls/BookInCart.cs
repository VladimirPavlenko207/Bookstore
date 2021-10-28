using Bookstore.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Controls
{
    public partial class BookInCart : UserControl
    {
        /// <summary>
        /// Происходит при удалении данного элемента заказа
        /// </summary>
        public event Action<BookInCart> ControlDeletion;
        /// <summary>
        /// Происходит при изменении кол-ва данной книги
        /// </summary>
        public event Action CountChanged;
        /// <summary>
        /// Данная книга
        /// </summary>
        public Book Book { get; private set; }
        /// <summary>
        /// Конечная цена данной книги
        /// </summary>
        public decimal PromPrice { get; private set; }
        /// <summary>
        /// Кол-во данных книг
        /// </summary>
        public int BookCount { get; private set; }

        /// <summary>
        /// Конструктр, принимающий первым параметром книгу, вторым - конечную цену
        /// </summary>
        /// <param name="book"></param>
        /// <param name="promPrice"></param>
        public BookInCart(Book book, decimal promPrice)
        {
            InitializeComponent();

            Book = book;
            PromPrice = promPrice;

            labelBookId.Text = book.Id.ToString();
            labelBookTitle.Text = book.Title;
            labelPrice.Text = book.Price.ToString();
            labelPromPrice.Text = promPrice.ToString();
            numericUpDown1.Value = 1;
        }

        /// <summary>
        /// Увеличение кол-во книг на 1
        /// </summary>
        public void BookCountIncrement()
        {
            numericUpDown1.Value++;
        }

        /// <summary>
        /// Получение суммы (произведение конечной цены книги на кол-во книг)
        /// </summary>
        /// <returns></returns>
        public decimal GetSum()
        {
            var sum = BookCount * PromPrice;
            labelSum.Text = sum.ToString();
            return sum;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            BookCount = (int)numericUpDown1.Value;
            GetSum();
            CountChanged?.Invoke();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ControlDeletion?.Invoke(this);
        }
    }
}
