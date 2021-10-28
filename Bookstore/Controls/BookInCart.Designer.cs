
namespace Bookstore.Controls
{
    partial class BookInCart
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInCart));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDlete = new System.Windows.Forms.Button();
            this.labelBookId = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPromPrice = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelSum = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.32008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.19496F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.48495F));
            this.tableLayoutPanel1.Controls.Add(this.buttonDlete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBookId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBookTitle, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPrice, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPromPrice, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSum, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonDlete
            // 
            this.buttonDlete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDlete.BackgroundImage")));
            this.buttonDlete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDlete.Location = new System.Drawing.Point(14, 3);
            this.buttonDlete.Name = "buttonDlete";
            this.buttonDlete.Size = new System.Drawing.Size(34, 35);
            this.buttonDlete.TabIndex = 0;
            this.buttonDlete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDlete.UseVisualStyleBackColor = true;
            this.buttonDlete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Location = new System.Drawing.Point(56, 0);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookId.Size = new System.Drawing.Size(50, 25);
            this.labelBookId.TabIndex = 1;
            this.labelBookId.Text = "label1";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(120, 0);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookTitle.Size = new System.Drawing.Size(50, 25);
            this.labelBookTitle.TabIndex = 1;
            this.labelBookTitle.Text = "label1";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(369, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPrice.Size = new System.Drawing.Size(50, 25);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "label1";
            // 
            // labelPromPrice
            // 
            this.labelPromPrice.AutoSize = true;
            this.labelPromPrice.Location = new System.Drawing.Point(448, 0);
            this.labelPromPrice.Name = "labelPromPrice";
            this.labelPromPrice.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPromPrice.Size = new System.Drawing.Size(50, 25);
            this.labelPromPrice.TabIndex = 1;
            this.labelPromPrice.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(548, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 27);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(621, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelSum.Size = new System.Drawing.Size(50, 25);
            this.labelSum.TabIndex = 1;
            this.labelSum.Text = "label1";
            // 
            // BookInCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookInCart";
            this.Size = new System.Drawing.Size(717, 42);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDlete;
        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPromPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelSum;
    }
}
