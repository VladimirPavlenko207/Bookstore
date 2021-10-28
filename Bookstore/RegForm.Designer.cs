
namespace Bookstore
{
    partial class RegForm
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPass1 = new System.Windows.Forms.Label();
            this.labelPass2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tableLayoutPanelMain.Controls.Add(this.labelUserName, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelPass1, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelPass2, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxUserName, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxPass1, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxPass2, 2, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonReg, 2, 4);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 6;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.24051F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.75949F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(344, 251);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(5, 40);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelUserName.Size = new System.Drawing.Size(39, 25);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Имя";
            // 
            // labelPass1
            // 
            this.labelPass1.AutoSize = true;
            this.labelPass1.Location = new System.Drawing.Point(5, 73);
            this.labelPass1.Name = "labelPass1";
            this.labelPass1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPass1.Size = new System.Drawing.Size(62, 25);
            this.labelPass1.TabIndex = 0;
            this.labelPass1.Text = "Пароль";
            // 
            // labelPass2
            // 
            this.labelPass2.AutoSize = true;
            this.labelPass2.Location = new System.Drawing.Point(5, 106);
            this.labelPass2.Name = "labelPass2";
            this.labelPass2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPass2.Size = new System.Drawing.Size(139, 25);
            this.labelPass2.TabIndex = 0;
            this.labelPass2.Text = "Повторить пароль";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(150, 43);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(178, 27);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.Location = new System.Drawing.Point(150, 76);
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.PasswordChar = '*';
            this.textBoxPass1.Size = new System.Drawing.Size(177, 27);
            this.textBoxPass1.TabIndex = 1;
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Location = new System.Drawing.Point(150, 109);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.PasswordChar = '*';
            this.textBoxPass2.Size = new System.Drawing.Size(177, 27);
            this.textBoxPass2.TabIndex = 1;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(150, 142);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(177, 42);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 251);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPass1;
        private System.Windows.Forms.Label labelPass2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPass1;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.Button buttonReg;
    }
}