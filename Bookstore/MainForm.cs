using Bookstore.Entities;
using Bookstore.Entities.Models;
using Bookstore.Enums;
using Bookstore.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class MainForm : Form
    {
        private static MainForm _instance;
        private static User CurrentUser { get; set; }
        private static Book CurrentBook { get; set; }
        private static decimal CurrentBookPromPrice { get; set; }

        private BookEditorForm _bookEditorForm;
        private PromOperations promOperations;
        private int[] _promPeriodIds;
        private PromOperations PromOperations 
        {
            get => promOperations;
            set
            {
                promOperations = value;
                PromPeriodControlsSetting();
            }
        }

        private void PromPeriodControlsSetting()
        {
            switch (PromOperations)
            {
                case PromOperations.None:
                    panelEditPeriod.Visible = false;
                    panelEditPromotion.Visible = false;
                    panelPromPeriod.Enabled = true;
                    break;
                case PromOperations.PromEdit:
                    panelEditPeriod.Visible = true;
                    panelEditPromotion.Visible = true;
                    panelEditPeriod.Enabled = false;
                   
                    break;
                case PromOperations.PromPeriodEdit:
                    panelEditPeriod.Visible = true;
                    panelEditPromotion.Visible = false;
                    panelEditPeriod.Enabled = true;
                    panelPromPeriod.Enabled = false;
                    break;
            }
        }

        private MainForm()
        {
            InitializeComponent();

            _bookEditorForm = BookEditorForm.GetInstance(CurrentBook);
            _bookEditorForm.DataChenged += UpdateForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstSetting();
        }

        private void UpdateForm()
        {
            LoadFiltersAsync();
            LoadRequestedBooksAsync(BooksRequests.GetAvailableBooks);
            SetAdminsPanel();
        }

        private void FirstSetting()
        {
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            SetAdminsPanel();
            LoadFiltersAsync();

            comboBoxAuthF.SelectedIndexChanged += ComboBoxFilters_SelectedIndexChanged;
            comboBoxGenreF.SelectedIndexChanged += ComboBoxFilters_SelectedIndexChanged;
            comboBoxPublF.SelectedIndexChanged += ComboBoxFilters_SelectedIndexChanged;
            comboBoxConditions.SelectedIndexChanged += comboBoxConditions_SelectedIndexChanged;
            comboBoxSortBy.SelectedIndexChanged += comboBoxSortBy_SelectedIndexChanged;

            labelUserRole.Text = string.Empty;
            labelUserName.Text = string.Empty;
            PromOperations = PromOperations.None;
            panelGenres.Visible = false;
        }

        private async void LoadFiltersAsync()
        {
            using BookStoreContext context = new();
            // context.CreateTestData(); // Раскоментировать здесь и в BookStoreContext если нужно пересоздать базу   
            var authors = await Task.Run(() => context.Authors?.Select(a => a.Name).OrderBy(n => n).ToArray());
            InsertItemInControl(comboBoxAuthF, authors, "Все авторы");
            var publishers = await Task.Run(() => context.Publishers?.Select(p => p.Name).OrderBy(n => n).ToArray());
            InsertItemInControl(comboBoxPublF, publishers, "Все издательства");
            var genres = await Task.Run(() => context.Genres?.Select(g => g.Title).OrderBy(t => t).ToArray());
            InsertItemInControl(comboBoxGenreF, genres, "Все жанры");
            var conditions = new string[] { "Все книги", "Новинки", "Все авторы" };
            InsertItemInControl(comboBoxConditions, conditions);
            var sortBy = new string[] { "популярности ▲", "популярности ▼" };
            InsertItemInControl(comboBoxSortBy, sortBy);
        }

        private void InsertItemInControl(ComboBox comboBox, string[] values, string head = null)
        {
            comboBox.Items.Clear();
            if (head is not null) comboBox.Items.Add(head);
            comboBox.Items.AddRange(values);
            comboBox.SelectedIndex = 0;
        }

        private void ComboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRequestedBooksAsync(BooksRequests.GetAvailableBooks);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                GetDetailedBookDataAsync(BooksRequests.GetBookByTitle);
        }

        private async void LoadRequestedBooksAsync(Func<BookStoreContext, object, IQueryable<Book>> func)
        {
            using BookStoreContext context = new();
            string title = textBoxSearch.Text;

            var books = await Task.Run(() => func(context, title));
            books = await Task.Run(() => IncludeFiltersAsync(context, books));
            ShowModels(books);
        }

        private void ShowModels<T>(IQueryable<T> models)
        {
            if (models is null) return;

            dataGridView1.Rows.Clear();
            SetDGVHeads(typeof(T).Name);
            foreach (var model in models)
            {
                if (model is Book book)
                    dataGridView1.Rows.Add(book.Id, book.Title, book.Authors[0].Name, $"{book.Price} грн.");
                if (model is Author author)
                    dataGridView1.Rows.Add(author.Id, author.Name);
            }
            tableLayoutPanelSelectedBook.Visible = models.Any();
        }
        /// <summary>
        /// Установка заглавий столбцов dataGridView1
        /// </summary>
        /// <param name="typeName"></param>
        private void SetDGVHeads(string typeName)
        {
            string[] headers = null;
            switch (typeName)
            {
                case "Book":
                    headers = new[] { "Id", "Название книги", "Автор", "Цена" };
                    break;
                case "Author":
                    headers = new[] { "Id", "ФИО автора", null, null };
                    break;
            }
            for (int i = 0; i < headers?.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = headers[i];
            }
        }

        private async Task<IQueryable<Book>> IncludeFiltersAsync(BookStoreContext context, IQueryable<Book> books)
        {
            var children = tableLayoutPanelFilters.Controls;
            foreach (var item in children)
            {
                if (item is ComboBox box)
                {
                    string type = string.Empty;
                    string filter = string.Empty;
                    int count = 0;
                    int selectedIndex = 0;
                    box.Invoke(new Action(() =>
                    {
                        type = box.Tag.ToString();
                        filter = box.Text;
                        count = box.Items.Count;
                        selectedIndex = box.SelectedIndex;
                    }));
                    if (count == 0) continue;
                    if (selectedIndex == 0) continue;
                    switch (type)
                    {
                        case "Author":
                            var author = await Task.Run(() =>
                               AuthorsRequests.GetAuthorByName(context, filter).FirstOrDefault());
                            books = books.Where(b => b.Authors.Contains(author));
                            break;
                        case "Publisher":
                            books = books.Where(b => b.Publisher.Name == filter);
                            break;
                        case "Genre":
                            books = books.Where(b => b.Genre.Title == filter);
                            break;
                    }
                }
            }
            return books;
        }

        private async void GetDetailedBookDataAsync(Func<BookStoreContext, object, IQueryable<Book>> OneBookRequest)
        {
            using BookStoreContext context = new();

            var title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            CurrentBook = await Task.Run(() => OneBookRequest(context, title).FirstOrDefault());

            tableLayoutPanelSelectedBook.Visible = CurrentBook is not null;
            if (CurrentBook is null) return;

            comboBoxAuthB2.DataSource = CurrentBook.Authors?.Select(a => a.Name).ToArray();
            labelBookName.Text = CurrentBook.Title;
            labelGenreB2.Text = CurrentBook.Genre.Title;
            labellReleaseB2.Text = CurrentBook.Released.ToString();
            labelPagesB2.Text = CurrentBook.Pages.ToString();
            SetPriceAsync(CurrentBook);

            labelPreviewB2.Visible = labelPreviewB1.Visible = CurrentBook.Previous is not null;
            labelPreviewB2.Text = CurrentBook.Previous?.Title;
            labelPublisherB2.Text = CurrentBook.Publisher.Name;
        }

        private async void SetPriceAsync(Book book)
        {
            using BookStoreContext context = new();
            var currentPromotions = await Task.Run(() => context.PromotionPeriods.Where(
                p => p.Begin <= DateTime.Now && p.End >= DateTime.Now && p.Books.Contains(book)));

            Promotion promotion = await Task.Run(() => context.Promotions.FirstOrDefault(
                p => p.DiscountPercentage == currentPromotions.Max(p => p.Promotion.DiscountPercentage)));

            decimal percentage = 0;
            if (promotion is not null)
                percentage = promotion.DiscountPercentage;

            CurrentBookPromPrice = book.Price - book.Price * percentage / 100;
            SetPromotionPrice(book.Price, CurrentBookPromPrice);
            ShowPromotionInfo(promotion);

        }

        private void ShowPromotionInfo(Promotion promotion)
        {
            labelPromotionB1.Visible = labelPromotionB2.Visible = promotion is not null;
            labelPromotionB2.Text = $"{promotion?.Title}";
        }

        private void SetPromotionPrice(decimal price, decimal promPrice)
        {
            labelPriceB2.Visible = promPrice != price;
            if (promPrice != price)
            {
                labelPriceB2.Text = price.ToString();
                labelPromPriceB2.Text = promPrice.ToString();
            }
            else labelPromPriceB2.Text = price.ToString();
            labelPromPriceB2.Text += " грн.";
        }

        public static MainForm GetInstance(User user = null)
        {
            CurrentUser = user;
            return _instance ??= new MainForm();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (CurrentUser is null)
            {
                AuthForm.GetInstance().ShowDialog();
                if (CurrentUser is null) return;

                labelUserName.Text = CurrentUser.UserName;
                labelUserRole.Text = CurrentUser.GetType().Name.ToString();
                panelAuth.BackColor = Color.Green;
                buttonEnter.Text = "Выйти";
            }
            else
            {
                CurrentUser = null;
                labelUserName.Text = string.Empty;
                labelUserRole.Text = string.Empty;
                panelAuth.BackColor = Color.LightGray;
                buttonEnter.Text = "Войти";
                _bookEditorForm.Close();
            }
            SetAdminsPanel();
        }

        private void SetAdminsPanel()
        {
            panelAdmin.Visible = CurrentUser is Admin;
            if (CurrentUser is Admin)
                LoadPromotionsAndPromPeriodsAsync();
        }

        private async void LoadPromotionsAndPromPeriodsAsync()
        {
            using BookStoreContext context = new();
            var promotions = await Task.Run(() => context.Promotions.ToList());
            var promPeriods = await Task.Run(() => context.PromotionPeriods.Include(p => p.Books).ToList());

            ControlsOperations.AddStringItemsInComboBox(comboBoxEditPeriodPromotions, promotions.Select(p => p.Title).ToArray());
           
            var samplingOfPeriods = promPeriods.Select(pp => new 
            {
                pp.Id,
                pp.Promotion.Title,
                begin = pp.Begin.ToShortDateString(),
                end = pp.End.ToShortDateString(),
                pp.Promotion.DiscountPercentage
            }).ToArray();
            List<string> list = new(samplingOfPeriods.Length);
            _promPeriodIds = new int[samplingOfPeriods.Length];
            int index = 0;
            foreach (var item in samplingOfPeriods)
            {
                _promPeriodIds[index++] = item.Id;
                list.Add($"{item.Title} {item.begin} {item.end} {item.DiscountPercentage}%");
            }
            ControlsOperations.AddStringItemsInComboBox(comboBoxPromPeriod, list.ToArray());

            SetButtonsDeleteEnable();
        }

        private void SetButtonsDeleteEnable()
        {
            buttonDeletePromPeriod.Enabled = comboBoxPromPeriod.Items.Count > 0;
            buttonDeleteBooksPromPeriod.Enabled = comboBoxPromPeriodBooks.Items.Count > 0;
            buttonEditPeriodDeleteProm.Enabled = comboBoxEditPeriodPromotions.Items.Count > 0;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text) || string.IsNullOrWhiteSpace(textBoxSearch.Text)) return;
            LoadRequestedBooksAsync(BooksRequests.GetBookByTitle);
        }

        private void comboBoxConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var condition = comboBoxConditions.Text;
            switch (condition)
            {
                case "Все книги":
                    LoadRequestedBooksAsync(BooksRequests.GetAvailableBooks);
                    break;
                case "Новинки":
                    LoadRequestedBooksAsync(BooksRequests.GetNewAvailableBooks);
                    break;
                case "Все авторы":
                    LoadRequestedAuthorsAsync(AuthorsRequests.GetALLAuthors);
                    break;
            }
        }

        private async void LoadRequestedAuthorsAsync(Func<BookStoreContext, object, IQueryable<Author>> func)
        {
            using BookStoreContext context = new();
            var authors = await Task.Run(() => func(context, null));
            ShowModels(authors);
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sortBy = comboBoxSortBy.Text;
            switch (sortBy)
            {
                case "популярности ▲":
                    if (comboBoxConditions.Text == "Все авторы")
                        LoadRequestedAuthorsAsync(AuthorsRequests.GetLessPopularFirstAuthors);
                    else
                        LoadRequestedBooksAsync(BooksRequests.GetSortedBooksBySoldCountAcc);
                    break;
                case "популярности ▼":
                    if (comboBoxConditions.Text == "Все авторы")
                        LoadRequestedAuthorsAsync(AuthorsRequests.GetMorePopularFirstAuthors);
                    else
                        LoadRequestedBooksAsync(BooksRequests.GetSortedBooksBySoldCountDecc);
                    break;
            }
        }


        private void buttonShoppingCart_Click(object sender, EventArgs e)
        {
            var form = CartForm.GetInstance(CurrentUser);
            form.Show();
            form.Activate();
        }

        private void buttonBookToCart_Click(object sender, EventArgs e)
        {
            CartForm.GetInstance(CurrentUser).AddBookControl(CurrentBook, CurrentBookPromPrice);
            MessageBox.Show($"Книга \"{CurrentBook.Title}\" добавлена в корзиную");
        }

        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            OpenBookEditor(BookOperation.Edit, CurrentBook);
        }

        private void buttonCreateBook_Click(object sender, EventArgs e)
        {
            OpenBookEditor(BookOperation.Create, null);
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            OpenBookEditor(BookOperation.Delete, CurrentBook);
        }

        private void buttonWriteOffBook_Click(object sender, EventArgs e)
        {
            OpenBookEditor(BookOperation.WriteOff, CurrentBook);
        }

        private void OpenBookEditor(BookOperation operation, Book currentBook)
        {
            _bookEditorForm = BookEditorForm.GetInstance(currentBook);
            _bookEditorForm.Show();
            _bookEditorForm.Activate();
            _bookEditorForm.BookOperation = operation;
        }

        private void buttonAddPromPeriod_Click(object sender, EventArgs e)
        {
            PromOperations = PromOperations.PromPeriodEdit;
        }

        private void buttonEditPeriodAddProm_Click(object sender, EventArgs e)
        {
            PromOperations = PromOperations.PromEdit;
        }

        private void buttonEditPromotionSave_Click(object sender, EventArgs e)
        {
           
            var message = "Сохранить в базе новую акцию?";
            if (MessageBox.Show(message, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                SaveNewPromotionAsync();

                PromOperations = PromOperations.PromPeriodEdit;
        }

        private async void SaveNewPromotionAsync()
        {
            var promotion = new Promotion()
            {
                Title = textBoxEditPromotion.Text,
                DiscountPercentage = (int)numericUpDownEditPromotion.Value
            };
            using BookStoreContext context = new();
            await Task.Run(() =>
            {
                context.Promotions.Add(promotion);
                context.SaveChanges();
            });
            MessageBox.Show($"Новая акция ({promotion.Title}) успешно сохранена!");
            UpdateForm();
        }

        private void buttonEditPeriodSave_Click(object sender, EventArgs e)
        {
            var message = $"Сохранить в базе новый период акции:\n\t{comboBoxEditPeriodPromotions.Text}" +
                $"\n\tначало периода: {dateTimePickerBegin.Value.ToShortDateString()}" +
                $"\n\tконец периода: {dateTimePickerEnd.Value.ToShortDateString()}";
            if (MessageBox.Show(message, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                SaveNewPromPeriodAsync();

            PromOperations = PromOperations.None;
        }

        private async void SaveNewPromPeriodAsync()
        {
            using BookStoreContext context = new();
            var period = new PromotionPeriod();
            var title = comboBoxEditPeriodPromotions.Text;
            period.Begin = dateTimePickerBegin.Value;
            period.End = dateTimePickerEnd.Value;
            await Task.Run(() =>
            {
                period.Promotion = context.Promotions.FirstOrDefault(p => p.Title == title);
                context.PromotionPeriods.Add(period);
                context.SaveChanges();
            });
            MessageBox.Show($"Новый период акции ({title}) успешно сохранен!");
            UpdateForm();
        }

        private void comboBoxPromPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBooksOfCurrentPromPeriodAsync();
        }

        private async void LoadBooksOfCurrentPromPeriodAsync()
        {
            var selectedIndex = comboBoxPromPeriod.SelectedIndex;
            using BookStoreContext context = new();
            var booksNames = await Task.Run(() => context.PromotionPeriods.Include(pp => pp.Books).
             FirstOrDefault(pp => pp.Id == _promPeriodIds[selectedIndex]).Books.Select(b=>b.Title));

            ControlsOperations.AddStringItemsInComboBox(comboBoxPromPeriodBooks, booksNames.ToArray());
            SetButtonsDeleteEnable();
        }

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            ControlsOperations.SetComboBoxDropDownWidth(sender as ComboBox);
        }

        private void buttonAddBooksPromPeriod_Click(object sender, EventArgs e)
        {
            var message = $"Внести книгу \"{CurrentBook.Title}\" в текущий период акции и сохранить в базе?";
            if (MessageBox.Show(message, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!comboBoxPromPeriodBooks.Items.Contains(CurrentBook.Title))
                {
                    ControlsOperations.AddUniqueStringItemToComboBox(comboBoxPromPeriodBooks, CurrentBook.Title);
                    comboBoxPromPeriodBooks.SelectedItem = CurrentBook.Title;
                    SaveChangesInPromPeriodBooksAsync(true, CurrentBook.Title);
                }
                else MessageBox.Show("Такая книга уже внесена!");
            }  
        }

        private async void SaveChangesInPromPeriodBooksAsync(bool isBookAdd, string title)
        {
            var selectedIndex = comboBoxPromPeriod.SelectedIndex;
            using BookStoreContext context = new();
            Book book = null;
            await Task.Run(() =>
            {
                if (isBookAdd)
                {
                    book = context.Books.FirstOrDefault(b => b.Title == title);
                    context.PromotionPeriods.Include(pp => pp.Books).
                      FirstOrDefault(pp => pp.Id == _promPeriodIds[selectedIndex]).Books.Add(book);
                }
                else
                {
                    book = context.Books.FirstOrDefault(b => b.Title == title);
                    context.PromotionPeriods.Include(pp => pp.Books).
                     FirstOrDefault(pp => pp.Id == _promPeriodIds[selectedIndex]).Books.Remove(book);
                }
                context.SaveChanges();
            });
            var message = isBookAdd ? "занесена" : "удалена";
            MessageBox.Show($"Книга ({book?.Title}) успешно {message}!");
            UpdateForm();
        }

        private void buttonDeleteBooksPromPeriod_Click(object sender, EventArgs e)
        {
            var title = comboBoxPromPeriodBooks.Text;
            var message = $"Удалить книгу \"{title}\" из данного периода акции?";
            if (MessageBox.Show(message, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ControlsOperations.DeleteStringItemFromComboBox(comboBoxPromPeriodBooks, title);
                if (comboBoxPromPeriodBooks.Items.Count > 0)
                    comboBoxPromPeriodBooks.SelectedIndex = 0;
                SaveChangesInPromPeriodBooksAsync(false, title);
            }
        }

        private void buttonDeletePromPeriod_Click(object sender, EventArgs e)
        {
            var message = "Удалить из базы текущий период акции?";
            if (MessageBox.Show(message, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                DeletePromPeriodAndSaveAsync();
        }

        private async void DeletePromPeriodAndSaveAsync()
        {
            var index = comboBoxPromPeriod.SelectedIndex;
            using BookStoreContext context = new();
            bool result= await Task.Run(() =>
            {
                if (context.PromotionPeriods.Include(pp => pp.Books).
                FirstOrDefault(pp => pp.Id == _promPeriodIds[index]).Books.Count > 0)
                {
                    MessageBox.Show("Сначала нужно удалить книги из этого периода акции!");
                    return false;
                }

                var period = context.PromotionPeriods.FirstOrDefault(pp => pp.Id == _promPeriodIds[index]);
                context.PromotionPeriods.Remove(period);
                context.SaveChanges();
                return true;
            });
            if (!result) return;
            MessageBox.Show($"Период акции ({comboBoxPromPeriod.Text}) успешно удален!");
            UpdateForm();
        }

        private void buttonEditPeriodDeleteProm_Click(object sender, EventArgs e)
        {
            var message = $"Удалить из базы данную акцию ({comboBoxEditPeriodPromotions.Text})?";
            if (MessageBox.Show(message, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                DeletePromotionAndSaveAsync();
        }

        private async void DeletePromotionAndSaveAsync()
        {
            var title = comboBoxEditPeriodPromotions.Text;
            using BookStoreContext context = new();
            bool result = await Task.Run(() =>
             {
                 var promotion = context.Promotions.FirstOrDefault(p => p.Title == title);
                 if (context.PromotionPeriods.Where(pp => pp.Promotion.Id == promotion.Id).Any())
                 {
                     MessageBox.Show("Сначала нужно удалить все периоды акций, ссылающиеся на эту акцию!");
                     return false;
                 }
                 context.Promotions.Remove(promotion);
                 context.SaveChanges();
                 return true;
             });
            if (!result) return;
            MessageBox.Show($"Акция ({title}) успешно удалена!");
            UpdateForm();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            RegForm.GetInstance().ShowDialog();
        }

        private void buttonGenres_Click(object sender, EventArgs e)
        {
            panelGenres.Visible = !panelGenres.Visible;
        }

        private void buttonShowPopGenres_Click(object sender, EventArgs e)
        {
            ShowPopGenresAsync();
        }

        private async void ShowPopGenresAsync()
        {
            var begin = dateTimePickerPopGenresBegin.Value;
            var end = dateTimePickerPopGenresEnd.Value;

            using BookStoreContext context = new();
            await Task.Run(() =>
            {
                var groups = context.Orders.Where(o => o.PurchaseDate >= begin && o.PurchaseDate <= end).
                SelectMany(o => o.OrderItems).Include(oi => oi.Book).ThenInclude(b => b.Genre).
                GroupBy(oi => oi.Book.Genre.Title).Select(p => new { genre = p.Key, count = p.Sum(a => a.Count) }).
                OrderByDescending(g => g.count);

                string mes = string.Empty;
                int i = 0;
                foreach (var group in groups)
                {
                    mes += $"{++i}). {group.genre} - {group.count}\n";
                }
                MessageBox.Show(mes);
            });
            panelGenres.Visible = false;
        }

    }
}
