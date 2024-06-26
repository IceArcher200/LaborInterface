﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Labor;
using Labor.MyEntities;
using Microsoft.EntityFrameworkCore;
using LibraryInterface;
namespace LibraryInterface
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        bool isLogin = false;
        public Authorization()
        {
            InitializeComponent();
            
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            string login = tbLogin.Text;
            string password = tbPassword.Password;

            
                var window = Application.Current.MainWindow;
                User user = (window as MainWindow)!.DbForUser.Users.Where((u) => u.Name == login && u.Password == password).Single();
                (window as MainWindow)!.userInfo = (window as MainWindow)!.DbForUser.UserInfo.Where(u => user.Id == u.UserId).ToList();
                //MessageBox.Show("Успешно!", $"Привет, {user.Name} + {user.Password}!");

                isLogin = true;
                this.Close();
            

        }

        private void LoginWindow_Closed(object sender, EventArgs e)
        {
            if (!isLogin)
                App.Current.Shutdown();
        }
        private void ForgetPassword_Click(object sender, RoutedEventArgs e)
        {
            PasswordRecovery passwordRecovery = new PasswordRecovery();
            passwordRecovery.Owner = this;
            passwordRecovery.Show();
        }
    }

}
