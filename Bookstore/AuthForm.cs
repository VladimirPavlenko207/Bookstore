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
    public partial class AuthForm : Form
    {
        private static AuthForm _instance;
        private AuthForm()
        {
            InitializeComponent();
            labelError.Text = string.Empty;
        }

        public static AuthForm GetInstance()
        {
            return _instance ??= new AuthForm();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == string.Empty || textBoxPass.Text == string.Empty)
            {
                OutputError();
                return;
            }
            FindUserAsync();
        }

        private async void FindUserAsync()
        {
            tableLayoutPanel1.Enabled = false;
            User user = null;
            var name = textBoxUserName.Text;
            var pass = textBoxPass.Text;
            await Task.Run(() =>
            {
                using BookStoreContext context = new();
                user = context.Users.FirstOrDefault(p =>
               p.UserName == name &&
               p.Password == pass);
            });

            if (user is null) OutputError();
            else ShopEntrance(user);
            tableLayoutPanel1.Enabled = true;
        }

        private void OutputError()
        {
            labelError.Text = "Неверный логин или пароль!";
        }

        private void ShopEntrance(User user)
        {
            Hide();
            MainForm.GetInstance(user);
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;
        }
    }
}
