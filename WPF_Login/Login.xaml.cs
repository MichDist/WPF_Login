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

using System.Data.SQLite;

namespace WPF_Login
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string cs = @"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db";
            var con = new SQLiteConnection(cs);

            con.Open();
            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO user(user_name, password) VALUES(@user_name, @password)";
            cmd.Parameters.AddWithValue("@user_name", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            /*cmd.CommandText = "CREATE TABLE user2(user_id INTEGER PRIMARY KEY, user_name TEXT, password TEXT)";
            cmd.ExecuteNonQuery();
            */
            con.Close();
        }
    }
}
