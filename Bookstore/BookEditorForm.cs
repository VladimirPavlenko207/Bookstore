using Bookstore.Entities;
using Bookstore.Entities.Models;
using Bookstore.Entities.Models.Base;
using Bookstore.Enums;
using Bookstore.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class BookEditorForm : Form
    {
        private static BookEditorForm _instance;
        private static string _defaultString = new('-', 10);
        private static string _separator = ", ";
        private static bool AddOrDelete;
        private static string[] AuthorsNames;
        private BookOperation bookOperation;

        private static Book CurrentBook { get; set; }
        private static ModelBase NewModel { get; set; }

        public BookOperation BookOperation 
        { 
            get => bookOperation;
            set
            {
                bookOperation = value;
                ControlsSetting();
            }
        }

        public event Action DataChenged;
        private BookEditorForm()
        {
            InitializeComponent();
            SetComboboxesValuesAsync();
            SetToolTips();
        }

        private void ControlsSetting()
        {
            switch (BookOperation)
            {
                case BookOperation.Edit:
                    panelMain.Enabled = true;
                    numericUpDownCount.Enabled = labelCount.Enabled = false;
                    Text = "Редактировать книгу";
                    break;
                case BookOperation.Create:
                    panelMain.Enabled = true;
                    numericUpDownCount.Enabled = labelCount.Enabled = true;
                    Text = "Создать новую книгу";
                    break;
                case BookOperation.Delete:
                    panelMain.Enabled = false;
                    numericUpDownCount.Enabled = labelCount.Enabled = false;
                    Text = "Удалить книгу";
                    break;
                case BookOperation.WriteOff:
                    panelMain.Enabled = false;
                    numericUpDownCount.Enabled = labelCount.Enabled = true;
                    Text = "Списать книгу";
                    break;
            }
        }

        private void SetToolTips()
        {
            ToolTip toolTipAddAuthor = new();
            toolTipAddAuthor.SetToolTip(buttonAddAuthor, "Добавить автора");

            ToolTip toolTipDeleteAuthor = new();
            toolTipDeleteAuthor.SetToolTip(buttonDeleteAuthor, "Удалить автора");

            ToolTip toolTipSelectAuthor = new();
            toolTipSelectAuthor.SetToolTip(buttonSelectAuthor, "Выбрать автора");

            ToolTip toolTipSaveInTheDatabase = new();
            toolTipSaveInTheDatabase.SetToolTip(buttonNewModel, "Сохранить в базе");
        }

        private async void SetComboboxesValuesAsync()
        {
            using BookStoreContext context = new();
            AuthorsNames = await Task.Run(() => context.Authors.Select(a => a.Name).ToArray());
            var genres = await Task.Run(() => context.Genres.Select(g => g.Title).ToArray());
            var publishers = await Task.Run(() => context.Publishers.Select(p => p.Name).ToArray());
            var previews = await Task.Run(() => context.Books.Select(b => b.Title).ToArray());

            AddComboboxItems(comboBoxAuthors, AuthorsNames, "Новый автор");
            AddComboboxItems(comboBoxPublisher, publishers, "Новое издательство");
            AddComboboxItems(comboBoxGenre, genres, "Новый жанр");
            AddComboboxItems(comboBoxPrevious, previews, _defaultString);

            SetSelectedIndexes();
        }

        private void AddComboboxItems(ComboBox comboBox, string[] items, string newString)
        {
            comboBox.Items.Clear();
            if (newString is not null) comboBox.Items.Add(newString);
            comboBox.Items.AddRange(items.ToArray());
        }

        private void FillInTheFields()
        {
            ClearForm();
            if (CurrentBook is null) return;

            labelBookIdValue.Text = CurrentBook.Id.ToString();
            textBoxBookName.Text = CurrentBook.Title;
            textBoxAuthors.Text = string.Join(_separator, CurrentBook.Authors.Select(a => a.Name).ToList());
            numericUpDownReleased.Value = CurrentBook.Released;
            numericUpDownCostPrice.Value = CurrentBook.CostPrice;
            numericUpDownPrice.Value = CurrentBook.Price;
            numericUpDownPages.Value = CurrentBook.Pages;
        }

        private void SetVisibleControls()
        {
            panelSelectAuthor.Visible = labelSelectAuthor.Visible = false;
            panelNewModel.Visible = labelNewModel.Visible = false;
        }

        public static BookEditorForm GetInstance(Book book)
        {
            CurrentBook = book;
            return _instance ??= new BookEditorForm();
        }

        private void ClearForm()
        {
            labelBookIdValue.Text = string.Empty;
            textBoxBookName.Text = string.Empty;
            textBoxAuthors.Text = string.Empty;
            numericUpDownCostPrice.Value = 0;
            numericUpDownCount.Value = 0;
            numericUpDownPages.Value = 0;
            numericUpDownPrice.Value = 0;
            numericUpDownReleased.Value = 0;
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            panelSelectAuthor.Visible = labelSelectAuthor.Visible = true;
            AddOrDelete = false;
            AddComboboxItems(comboBoxAuthors, textBoxAuthors.Text.Split(_separator), null);
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            panelSelectAuthor.Visible = labelSelectAuthor.Visible = true;
            AddOrDelete = true;
            AddComboboxItems(comboBoxAuthors, AuthorsNames, "Новый автор");
        }

        private void BookEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            ControlsOperations.SetComboBoxDropDownWidth(sender as ComboBox);
        }

        private void BookEditorForm_Activated(object sender, EventArgs e)
        {
            SetVisibleControls();
            FillInTheFields();
            SetSelectedIndexes();
        }

        private void SetSelectedIndexes()
        {
            var numGenre = CurrentBook is null ? -1 : comboBoxGenre.FindString(CurrentBook.Genre?.Title);
            comboBoxGenre.SelectedIndex = numGenre;
            var numPub = CurrentBook is null ? -1 : comboBoxPublisher.FindString(CurrentBook.Publisher?.Name);
            comboBoxPublisher.SelectedIndex = numPub;
            comboBoxAuthors.SelectedIndex = -1;

            string tmpStr;
            if (CurrentBook?.Previous is null) tmpStr = _defaultString;
            else tmpStr = CurrentBook?.Previous.Title;

            var numPrev = CurrentBook is null ? -1 : comboBoxPrevious.FindString(tmpStr);
            comboBoxPrevious.SelectedIndex = numPrev;
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool condition = (sender as ComboBox).SelectedIndex == 0;

            panelNewModel.Visible = labelNewModel.Visible = condition;
            panelAuthors.Enabled = !condition;
            comboBoxPublisher.Enabled = !condition;
            panelSelectAuthor.Enabled = !condition;
            if (condition) NewModel = new Genre();
            labelNewModel.Text = "Новый жанр";
        }

        private void comboBoxPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool condition = (sender as ComboBox).SelectedIndex == 0;

            panelNewModel.Visible = labelNewModel.Visible = condition;
            panelAuthors.Enabled = !condition;
            comboBoxGenre.Enabled = !condition;
            panelSelectAuthor.Enabled = !condition;
            if (condition) NewModel = new Publisher();
            labelNewModel.Text = "Новое издательство";
        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!AddOrDelete) return;

            bool condition = (sender as ComboBox).SelectedIndex == 0;

            panelNewModel.Visible = labelNewModel.Visible = condition;
            panelAuthors.Enabled = !condition;
            comboBoxGenre.Enabled = !condition;
            comboBoxPublisher.Enabled = !condition;
            if (condition) NewModel = new Author();
            labelNewModel.Text = "Новый автор";
        }

        private void buttonNewModel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewModel.Text) ||
                string.IsNullOrWhiteSpace(textBoxNewModel.Text)) return;
            CreateModelAsync();
        }

        private void ToTheStartPosition()
        {
            panelNewModel.Visible = labelNewModel.Visible = false;
            panelAuthors.Enabled = true;
            comboBoxGenre.Enabled = true;
            comboBoxPublisher.Enabled = true;
            comboBoxAuthors.Enabled = true;
        }

        private async void CreateModelAsync()
        {
            using BookStoreContext context = new();
            if (NewModel is Author author)
            {
                author.Name = textBoxNewModel.Text;
                await Task.Run(() => AddNewModelAndSave(context, context.Authors, author));
            }
            if (NewModel is Genre genre)
            {
                genre.Title = textBoxNewModel.Text;
                await Task.Run(() => AddNewModelAndSave(context, context.Genres, genre));
            }
            if (NewModel is Publisher publisher)
            {
                publisher.Name = textBoxNewModel.Text;
                await Task.Run(() => AddNewModelAndSave(context, context.Publishers, publisher));
            }
            ShowResultMessage();
            DataChenged?.Invoke();
            ToTheStartPosition();
            SetComboboxesValuesAsync();
            textBoxNewModel.Text = string.Empty;
        }

        private void ShowResultMessage()
        {
            string message = $"{labelNewModel.Text} ({textBoxNewModel.Text}) сохранился в базе.";
            MessageBox.Show(message, "Сохранение успешно!");
        }

        private void AddNewModelAndSave<T>(BookStoreContext context, DbSet<T> set, T model) where T : ModelBase
        {
            set.Add(model);
            SafePreservation(context, model);
        }

        private void buttonSelectAuthor_Click(object sender, EventArgs e)
        {
            if (AddOrDelete) AddAuthorToCurrentBook();
            else DeleteAuthorFromCurrentBook();

            panelSelectAuthor.Visible = labelSelectAuthor.Visible = false;
        }

        private void DeleteAuthorFromCurrentBook()
        {
            var authors = textBoxAuthors.Text.Split(_separator).ToList();
            authors.Remove(comboBoxAuthors.Text);
            textBoxAuthors.Text = string.Join(_separator, authors);
        }

        private void AddAuthorToCurrentBook()
        {
            var authors = textBoxAuthors.Text.Split(_separator).ToList();

            if (!authors.Contains(comboBoxAuthors.Text))
                authors.Add(comboBoxAuthors.Text);

            if (authors.Contains(string.Empty))
                authors.Remove(string.Empty);

            textBoxAuthors.Text = string.Join(_separator, authors);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MakeChangesAsync();
        }

        private async void MakeChangesAsync()
        {
            switch (bookOperation)
            {
                case BookOperation.Edit:
                    await SaveModifiedBookAsync();
                    break;
                case BookOperation.Create:
                    await SaveCreatedBookAsync(); 
                    break;
                case BookOperation.Delete:
                    await SaveAfterDeletionAsync(); 
                    break;
                case BookOperation.WriteOff:
                    await SaveAfterWriteOffAsync(); 
                    break;
            }
            DataChenged?.Invoke();
            Hide();
        }

        private async Task SaveAfterWriteOffAsync()
        {
            using BookStoreContext context = new();
            var book = await Task.Run(() => context.Books.Include(b => b.Authors).
            FirstOrDefault(b => b.Id == CurrentBook.Id));

            book.AvailableCount -= (int)numericUpDownCount.Value;
            SafePreservation(context, book);
        }

        private async Task SaveAfterDeletionAsync()
        {
            using BookStoreContext context = new();
            var book = await Task.Run(() => context.Books.Include(b => b.Authors).
            FirstOrDefault(b => b.Id == CurrentBook.Id));

            context.Books.Remove(book);
            SafePreservation(context, book);
        }

        private async Task SaveCreatedBookAsync()
        {
            using BookStoreContext context = new();
            var book = new Book();
            await FillingOutABookAsync(context, book);
            book.AvailableCount += (int)numericUpDownCount.Value;
            context.Books.Add(book);

            SafePreservation(context, book);
        }

        private void SafePreservation<T>(BookStoreContext context, T model) where T : ModelBase
        {
            ModelBase modelBase = Downcasting(model);
            var results = new List<ValidationResult>();
            var vContext = new ValidationContext(modelBase);
            try
            {
                context.SaveChanges();
                MessageBox.Show("Сохранения прошли успешно!");
            }
            catch (Exception)
            {
                if (!Validator.TryValidateObject(modelBase, vContext, results, true))
                {
                    string str = string.Empty;
                    foreach (var error in results)
                    {
                        str += $"{error.ErrorMessage}\n";
                    }
                    MessageBox.Show(str);
                }
            }
        }

        private ModelBase Downcasting<T>(T model) where T : ModelBase
        {
            if (model is Genre genre) return genre;
            if (model is Publisher publisher) return publisher;
            if (model is Author author) return author;

            return model;
        }

        private async Task FillingOutABookAsync(BookStoreContext context, Book book)
        {
            var tmp = comboBoxGenre.Text;
            if (CurrentBook?.Genre.Title != tmp)
                book.Genre = await Task.Run(() => context.Genres.FirstOrDefault(g => g.Title == tmp));
            else book.Genre = CurrentBook.Genre;

            tmp = comboBoxPublisher.Text;
            if (CurrentBook?.Publisher.Name != tmp)
                book.Publisher = await Task.Run(() => context.Publishers.FirstOrDefault(p => p.Name == tmp));
            else book.Publisher = CurrentBook.Publisher;

            tmp = comboBoxPrevious.Text;
            if (CurrentBook?.Previous?.Title != tmp)
                if (tmp != _defaultString)
                {
                    book.Previous = await Task.Run(() => context.Books.FirstOrDefault(b => b.Title == tmp));
                }
                else book.Previous = null;
            else book.Previous = CurrentBook.Previous;

            var authorsNames = textBoxAuthors.Text.Split(_separator).ToList();
            if (!StringOperations.AreTheListsTheSame(authorsNames, CurrentBook?.Authors.Select(a => a.Name).ToList()))
                book.Authors = await Task.Run(() => context.Authors.
                Where(a => authorsNames.Contains(a.Name)).ToList());
            else book.Authors = CurrentBook.Authors;

            book.Title = textBoxBookName.Text;
            book.Pages = (int)numericUpDownPages.Value;
            book.CostPrice = (int)numericUpDownCostPrice.Value;
            book.Price = (int)numericUpDownPrice.Value;
           
            book.Released = (int)numericUpDownReleased.Value;
            if (CurrentBook is not null)
                book.SoldCount = CurrentBook.SoldCount;
        }

        private async Task SaveModifiedBookAsync()
        {
            using BookStoreContext context = new();
            var book = await Task.Run(() => context.Books.Include(b => b.Authors).
            FirstOrDefault(b => b.Id == CurrentBook.Id));

            await FillingOutABookAsync(context, book);
            book.AvailableCount += (int)numericUpDownCount.Value;
            SafePreservation(context, book);
        }

    }
}
