using Bookstore.Entities;
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

namespace Bookstore
{
    public partial class RegForm : Form
    {
        private static RegForm _instance;
        private RegForm()
        {
            InitializeComponent();
        }

        public static RegForm GetInstance()
        {
            return _instance ??= new RegForm();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyString()) return;
            if (!ValidPass()) return;

            RegistrationAsync();
        }

        private async void RegistrationAsync()
        {
            User user = null;
            var name = textBoxUserName.Text;
            var pass = textBoxPass1.Text;
            string message = string.Empty;

            using BookStoreContext context = new();
            tableLayoutPanelMain.Enabled = false;
            bool result = await Task.Run(() =>
            {
                user = context.Users.FirstOrDefault(u => u.UserName == name);
                if (user is not null)
                {
                    message = $"Имя \"{name}\" уже существует!";
                    return false;
                }
                user = new()
                {
                    UserName = name,
                    Password = pass
                };
                context.Users.Add(user);
                context.SaveChanges();
                message = $"Регистрация прошла успешно!";
                return true;
            });
            tableLayoutPanelMain.Enabled = true;
            MessageBox.Show(message);
            if (result)
            {
                MainForm.GetInstance(user);
                Hide();
            }
        }

        private bool ValidPass()
        {
            if (textBoxPass1.Text == textBoxPass2.Text) return true;
            MessageBox.Show("Пароли не совпадают!");
            textBoxPass1.Text = textBoxPass2.Text = string.Empty;
            return false;
        }

        private bool CheckEmptyString()
        {
            var controls = tableLayoutPanelMain.Controls;
            foreach (var control in controls)
            {
                if(control is TextBox box)
                {
                    if (string.IsNullOrEmpty(box.Text) || string.IsNullOrWhiteSpace(box.Text))
                    {
                        MessageBox.Show("Не все поля заполненны!");
                        return false;
                    } 
                }
            }
            return true;
        }
    }
}
