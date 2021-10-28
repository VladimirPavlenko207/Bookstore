
namespace Bookstore
{
    partial class CartForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelBookPrice = new System.Windows.Forms.Label();
            this.labelBookPromPrice = new System.Windows.Forms.Label();
            this.labelBookCount = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalSum1 = new System.Windows.Forms.Label();
            this.labelTotalSum2 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(748, 67);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 8;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.labelTop, 2, 1);
            this.tableLayoutPanelTop.Controls.Add(this.labelId, 1, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelBookTitle, 2, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelBookPrice, 3, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelBookPromPrice, 4, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelBookCount, 5, 2);
            this.tableLayoutPanelTop.Controls.Add(this.labelSum, 6, 2);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 3;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(748, 78);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTop.Location = new System.Drawing.Point(108, 14);
            this.labelTop.Name = "labelTop";
            this.labelTop.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelTop.Size = new System.Drawing.Size(219, 26);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "В вашей корзине сейчас:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(60, 40);
            this.labelId.Name = "labelId";
            this.labelId.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelId.Size = new System.Drawing.Size(22, 25);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(108, 40);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookTitle.Size = new System.Drawing.Size(121, 25);
            this.labelBookTitle.TabIndex = 0;
            this.labelBookTitle.Text = "Название книги";
            // 
            // labelBookPrice
            // 
            this.labelBookPrice.AutoSize = true;
            this.labelBookPrice.Location = new System.Drawing.Point(364, 40);
            this.labelBookPrice.Name = "labelBookPrice";
            this.labelBookPrice.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookPrice.Size = new System.Drawing.Size(45, 25);
            this.labelBookPrice.TabIndex = 0;
            this.labelBookPrice.Text = "Цена";
            // 
            // labelBookPromPrice
            // 
            this.labelBookPromPrice.AutoSize = true;
            this.labelBookPromPrice.Location = new System.Drawing.Point(423, 40);
            this.labelBookPromPrice.Name = "labelBookPromPrice";
            this.labelBookPromPrice.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookPromPrice.Size = new System.Drawing.Size(125, 25);
            this.labelBookPromPrice.TabIndex = 0;
            this.labelBookPromPrice.Text = "Цена со скидкой";
            // 
            // labelBookCount
            // 
            this.labelBookCount.AutoSize = true;
            this.labelBookCount.Location = new System.Drawing.Point(556, 40);
            this.labelBookCount.Name = "labelBookCount";
            this.labelBookCount.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelBookCount.Size = new System.Drawing.Size(56, 25);
            this.labelBookCount.TabIndex = 0;
            this.labelBookCount.Text = "кол-во";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(620, 40);
            this.labelSum.Name = "labelSum";
            this.labelSum.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelSum.Size = new System.Drawing.Size(55, 25);
            this.labelSum.TabIndex = 0;
            this.labelSum.Text = "Сумма";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.tableLayoutPanelBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 387);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(748, 63);
            this.panelBottom.TabIndex = 1;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 6;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelBottom.Controls.Add(this.labelTotalSum1, 3, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.labelTotalSum2, 4, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.buttonBuy, 1, 1);
            this.tableLayoutPanelBottom.Controls.Add(this.labelError, 2, 1);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 2;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(748, 63);
            this.tableLayoutPanelBottom.TabIndex = 0;
            // 
            // labelTotalSum1
            // 
            this.labelTotalSum1.AutoSize = true;
            this.labelTotalSum1.Location = new System.Drawing.Point(544, 19);
            this.labelTotalSum1.Name = "labelTotalSum1";
            this.labelTotalSum1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelTotalSum1.Size = new System.Drawing.Size(108, 25);
            this.labelTotalSum1.TabIndex = 0;
            this.labelTotalSum1.Text = "Общая сумма:";
            // 
            // labelTotalSum2
            // 
            this.labelTotalSum2.AutoSize = true;
            this.labelTotalSum2.Location = new System.Drawing.Point(658, 19);
            this.labelTotalSum2.Name = "labelTotalSum2";
            this.labelTotalSum2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelTotalSum2.Size = new System.Drawing.Size(17, 25);
            this.labelTotalSum2.TabIndex = 0;
            this.labelTotalSum2.Text = "0";
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonBuy.Location = new System.Drawing.Point(23, 22);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(94, 38);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(123, 19);
            this.labelError.Name = "labelError";
            this.labelError.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelError.Size = new System.Drawing.Size(37, 28);
            this.labelError.TabIndex = 0;
            this.labelError.Text = "xxx";
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 67);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(748, 320);
            this.panelMain.TabIndex = 2;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.Activated += new System.EventHandler(this.CartForm_Activated);
            this.Deactivate += new System.EventHandler(this.CartForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CartForm_FormClosing);
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelBookPrice;
        private System.Windows.Forms.Label labelBookPromPrice;
        private System.Windows.Forms.Label labelBookCount;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.Label labelTotalSum1;
        private System.Windows.Forms.Label labelTotalSum2;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelError;
    }
}