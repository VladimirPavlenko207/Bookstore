
namespace Bookstore
{
    partial class BookEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.panelAuthors = new System.Windows.Forms.Panel();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelPrevious = new System.Windows.Forms.Label();
            this.labelReleased = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelCostPrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownReleased = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPages = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCostPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.comboBoxPrevious = new System.Windows.Forms.ComboBox();
            this.panelSelectAuthor = new System.Windows.Forms.Panel();
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.buttonSelectAuthor = new System.Windows.Forms.Button();
            this.labelBookId = new System.Windows.Forms.Label();
            this.labelBookIdValue = new System.Windows.Forms.Label();
            this.labelSelectAuthor = new System.Windows.Forms.Label();
            this.panelNewModel = new System.Windows.Forms.Panel();
            this.textBoxNewModel = new System.Windows.Forms.TextBox();
            this.buttonNewModel = new System.Windows.Forms.Button();
            this.labelNewModel = new System.Windows.Forms.Label();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.labelCount = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReleased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.panelSelectAuthor.SuspendLayout();
            this.panelNewModel.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 6;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMain.Controls.Add(this.textBoxBookName, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelBookName, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelAuthors, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.panelAuthors, 2, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelGenre, 1, 4);
            this.tableLayoutPanelMain.Controls.Add(this.labelPublisher, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelPrevious, 1, 6);
            this.tableLayoutPanelMain.Controls.Add(this.labelReleased, 1, 7);
            this.tableLayoutPanelMain.Controls.Add(this.labelPages, 1, 8);
            this.tableLayoutPanelMain.Controls.Add(this.labelCostPrice, 1, 9);
            this.tableLayoutPanelMain.Controls.Add(this.labelPrice, 1, 10);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownReleased, 2, 7);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownPages, 2, 8);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownCostPrice, 2, 9);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownPrice, 2, 10);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxGenre, 2, 4);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxPublisher, 2, 5);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxPrevious, 2, 6);
            this.tableLayoutPanelMain.Controls.Add(this.panelSelectAuthor, 4, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelBookId, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelBookIdValue, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelSelectAuthor, 4, 4);
            this.tableLayoutPanelMain.Controls.Add(this.panelNewModel, 4, 7);
            this.tableLayoutPanelMain.Controls.Add(this.labelNewModel, 4, 6);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanelMain.RowCount = 12;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(643, 456);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // textBoxBookName
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.textBoxBookName, 3);
            this.textBoxBookName.Location = new System.Drawing.Point(179, 54);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(430, 27);
            this.textBoxBookName.TabIndex = 1;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(31, 51);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookName.Size = new System.Drawing.Size(121, 25);
            this.labelBookName.TabIndex = 0;
            this.labelBookName.Text = "Название книги";
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Location = new System.Drawing.Point(31, 84);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelAuthors.Size = new System.Drawing.Size(62, 25);
            this.labelAuthors.TabIndex = 0;
            this.labelAuthors.Text = "Авторы";
            // 
            // panelAuthors
            // 
            this.panelAuthors.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.panelAuthors, 3);
            this.panelAuthors.Controls.Add(this.buttonDeleteAuthor);
            this.panelAuthors.Controls.Add(this.buttonAddAuthor);
            this.panelAuthors.Controls.Add(this.textBoxAuthors);
            this.panelAuthors.Location = new System.Drawing.Point(179, 87);
            this.panelAuthors.Name = "panelAuthors";
            this.panelAuthors.Size = new System.Drawing.Size(430, 33);
            this.panelAuthors.TabIndex = 2;
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(394, 2);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(33, 28);
            this.buttonDeleteAuthor.TabIndex = 2;
            this.buttonDeleteAuthor.Text = "-";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddAuthor.Location = new System.Drawing.Point(356, 2);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(33, 28);
            this.buttonAddAuthor.TabIndex = 2;
            this.buttonAddAuthor.Text = "+";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(3, 3);
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.ReadOnly = true;
            this.textBoxAuthors.Size = new System.Drawing.Size(347, 27);
            this.textBoxAuthors.TabIndex = 1;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(31, 123);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelGenre.Size = new System.Drawing.Size(48, 25);
            this.labelGenre.TabIndex = 0;
            this.labelGenre.Text = "Жанр";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(31, 157);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPublisher.Size = new System.Drawing.Size(103, 25);
            this.labelPublisher.TabIndex = 0;
            this.labelPublisher.Text = "Издательство";
            // 
            // labelPrevious
            // 
            this.labelPrevious.AutoSize = true;
            this.labelPrevious.Location = new System.Drawing.Point(31, 199);
            this.labelPrevious.Name = "labelPrevious";
            this.labelPrevious.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPrevious.Size = new System.Drawing.Size(142, 25);
            this.labelPrevious.TabIndex = 0;
            this.labelPrevious.Text = "Предыдущая книга";
            // 
            // labelReleased
            // 
            this.labelReleased.AutoSize = true;
            this.labelReleased.Location = new System.Drawing.Point(31, 233);
            this.labelReleased.Name = "labelReleased";
            this.labelReleased.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelReleased.Size = new System.Drawing.Size(95, 25);
            this.labelReleased.TabIndex = 0;
            this.labelReleased.Text = "Год издания";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(31, 272);
            this.labelPages.Name = "labelPages";
            this.labelPages.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPages.Size = new System.Drawing.Size(119, 25);
            this.labelPages.TabIndex = 0;
            this.labelPages.Text = "Кол-во страниц";
            // 
            // labelCostPrice
            // 
            this.labelCostPrice.AutoSize = true;
            this.labelCostPrice.Location = new System.Drawing.Point(31, 305);
            this.labelCostPrice.Name = "labelCostPrice";
            this.labelCostPrice.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelCostPrice.Size = new System.Drawing.Size(103, 25);
            this.labelCostPrice.TabIndex = 0;
            this.labelCostPrice.Text = "Цена закупки";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(31, 338);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPrice.Size = new System.Drawing.Size(112, 25);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Цена продажи";
            // 
            // numericUpDownReleased
            // 
            this.numericUpDownReleased.Location = new System.Drawing.Point(179, 236);
            this.numericUpDownReleased.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownReleased.Name = "numericUpDownReleased";
            this.numericUpDownReleased.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownReleased.TabIndex = 3;
            // 
            // numericUpDownPages
            // 
            this.numericUpDownPages.Location = new System.Drawing.Point(179, 275);
            this.numericUpDownPages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPages.Name = "numericUpDownPages";
            this.numericUpDownPages.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownPages.TabIndex = 3;
            // 
            // numericUpDownCostPrice
            // 
            this.numericUpDownCostPrice.Location = new System.Drawing.Point(179, 308);
            this.numericUpDownCostPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCostPrice.Name = "numericUpDownCostPrice";
            this.numericUpDownCostPrice.Size = new System.Drawing.Size(151, 27);
            this.numericUpDownCostPrice.TabIndex = 3;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(179, 341);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownPrice.TabIndex = 3;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(179, 126);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(151, 28);
            this.comboBoxGenre.TabIndex = 4;
            this.comboBoxGenre.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(179, 160);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPublisher.TabIndex = 4;
            this.comboBoxPublisher.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBoxPublisher.SelectedIndexChanged += new System.EventHandler(this.comboBoxPublisher_SelectedIndexChanged);
            // 
            // comboBoxPrevious
            // 
            this.comboBoxPrevious.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrevious.FormattingEnabled = true;
            this.comboBoxPrevious.Location = new System.Drawing.Point(179, 202);
            this.comboBoxPrevious.Name = "comboBoxPrevious";
            this.comboBoxPrevious.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPrevious.TabIndex = 4;
            this.comboBoxPrevious.DropDown += new System.EventHandler(this.comboBox_DropDown);
            // 
            // panelSelectAuthor
            // 
            this.panelSelectAuthor.AutoSize = true;
            this.panelSelectAuthor.Controls.Add(this.comboBoxAuthors);
            this.panelSelectAuthor.Controls.Add(this.buttonSelectAuthor);
            this.panelSelectAuthor.Location = new System.Drawing.Point(405, 160);
            this.panelSelectAuthor.Name = "panelSelectAuthor";
            this.panelSelectAuthor.Size = new System.Drawing.Size(204, 36);
            this.panelSelectAuthor.TabIndex = 6;
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(3, 5);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(159, 28);
            this.comboBoxAuthors.TabIndex = 4;
            this.comboBoxAuthors.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthors_SelectedIndexChanged);
            // 
            // buttonSelectAuthor
            // 
            this.buttonSelectAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectAuthor.Location = new System.Drawing.Point(168, 5);
            this.buttonSelectAuthor.Name = "buttonSelectAuthor";
            this.buttonSelectAuthor.Size = new System.Drawing.Size(33, 28);
            this.buttonSelectAuthor.TabIndex = 2;
            this.buttonSelectAuthor.Text = "+";
            this.buttonSelectAuthor.UseVisualStyleBackColor = true;
            this.buttonSelectAuthor.Click += new System.EventHandler(this.buttonSelectAuthor_Click);
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Location = new System.Drawing.Point(31, 26);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookId.Size = new System.Drawing.Size(68, 25);
            this.labelBookId.TabIndex = 0;
            this.labelBookId.Text = "ID книги";
            // 
            // labelBookIdValue
            // 
            this.labelBookIdValue.AutoSize = true;
            this.labelBookIdValue.Location = new System.Drawing.Point(179, 26);
            this.labelBookIdValue.Name = "labelBookIdValue";
            this.labelBookIdValue.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookIdValue.Size = new System.Drawing.Size(68, 25);
            this.labelBookIdValue.TabIndex = 0;
            this.labelBookIdValue.Text = "ID книги";
            // 
            // labelSelectAuthor
            // 
            this.labelSelectAuthor.AutoSize = true;
            this.labelSelectAuthor.Location = new System.Drawing.Point(405, 123);
            this.labelSelectAuthor.Name = "labelSelectAuthor";
            this.labelSelectAuthor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelSelectAuthor.Size = new System.Drawing.Size(121, 25);
            this.labelSelectAuthor.TabIndex = 0;
            this.labelSelectAuthor.Text = "Выбрать автора";
            // 
            // panelNewModel
            // 
            this.panelNewModel.AutoSize = true;
            this.panelNewModel.Controls.Add(this.textBoxNewModel);
            this.panelNewModel.Controls.Add(this.buttonNewModel);
            this.panelNewModel.Location = new System.Drawing.Point(405, 236);
            this.panelNewModel.Name = "panelNewModel";
            this.panelNewModel.Size = new System.Drawing.Size(204, 33);
            this.panelNewModel.TabIndex = 6;
            // 
            // textBoxNewModel
            // 
            this.textBoxNewModel.Location = new System.Drawing.Point(3, 3);
            this.textBoxNewModel.Name = "textBoxNewModel";
            this.textBoxNewModel.Size = new System.Drawing.Size(159, 27);
            this.textBoxNewModel.TabIndex = 0;
            // 
            // buttonNewModel
            // 
            this.buttonNewModel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewModel.Location = new System.Drawing.Point(168, 1);
            this.buttonNewModel.Name = "buttonNewModel";
            this.buttonNewModel.Size = new System.Drawing.Size(33, 28);
            this.buttonNewModel.TabIndex = 2;
            this.buttonNewModel.Text = "+";
            this.buttonNewModel.UseVisualStyleBackColor = true;
            this.buttonNewModel.Click += new System.EventHandler(this.buttonNewModel_Click);
            // 
            // labelNewModel
            // 
            this.labelNewModel.AutoSize = true;
            this.labelNewModel.Location = new System.Drawing.Point(405, 199);
            this.labelNewModel.Name = "labelNewModel";
            this.labelNewModel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelNewModel.Size = new System.Drawing.Size(73, 25);
            this.labelNewModel.TabIndex = 0;
            this.labelNewModel.Text = "Выбрать ";
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 4;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.092485F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.90752F));
            this.tableLayoutPanelBottom.Controls.Add(this.labelCount, 1, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.numericUpDownCount, 2, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.buttonSave, 1, 1);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 3;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(643, 231);
            this.tableLayoutPanelBottom.TabIndex = 0;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(30, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelCount.Size = new System.Drawing.Size(153, 25);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Кол-во экземпляров";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(189, 3);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(140, 27);
            this.numericUpDownCount.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(30, 36);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 29);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanelMain);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(643, 456);
            this.panelMain.TabIndex = 3;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.tableLayoutPanelBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 395);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(643, 231);
            this.panelBottom.TabIndex = 4;
            // 
            // BookEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 626);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BookEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор";
            this.Activated += new System.EventHandler(this.BookEditorForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookEditorForm_FormClosing);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.panelAuthors.ResumeLayout(false);
            this.panelAuthors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReleased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.panelSelectAuthor.ResumeLayout(false);
            this.panelNewModel.ResumeLayout(false);
            this.panelNewModel.PerformLayout();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Panel panelAuthors;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.TextBox textBoxAuthors;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelPrevious;
        private System.Windows.Forms.Label labelReleased;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelCostPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownReleased;
        private System.Windows.Forms.NumericUpDown numericUpDownPages;
        private System.Windows.Forms.NumericUpDown numericUpDownCostPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.ComboBox comboBoxPrevious;
        private System.Windows.Forms.Panel panelSelectAuthor;
        private System.Windows.Forms.ComboBox comboBoxAuthors;
        private System.Windows.Forms.Panel panelNewModel;
        private System.Windows.Forms.Button buttonSelectAuthor;
        private System.Windows.Forms.TextBox textBoxNewModel;
        private System.Windows.Forms.Button buttonNewModel;
        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.Label labelBookIdValue;
        private System.Windows.Forms.Label labelSelectAuthor;
        private System.Windows.Forms.Label labelNewModel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Panel panelBottom;
    }
}