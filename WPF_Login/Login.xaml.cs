using System;
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
using System.Windows.Navigation;

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
            
            cmd.CommandText = "SELECT user_id, user_name, password FROM user WHERE @user_name = user_name";

            cmd.Parameters.AddWithValue("@user_name", txtUsername.Text);
            //cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            cmd.Prepare();

            SQLiteDataReader rdr = cmd.ExecuteReader();

            // Create user
            user usr = new user();
            // Read result                                  
            while (rdr.Read())
            {
                usr.setName(rdr.GetString(1));
                usr.setPassword(rdr.GetString(2));
            }

            // Check if credentials are correct
            if (usr.getPassword() == txtPassword.Text)
            {
                //Navigate to main window
                var newWindow = new MainWindow(); 
                newWindow.Show(); 
                this.Close(); 
            }
            else
            {
                lblPasswordCheck.Content = "Wrong password!";
            }
 

            /* User anlegen 
            cmd.CommandText = "INSERT INTO user(user_name, password) VALUES(@user_name, @password)";
            cmd.Parameters.AddWithValue("@user_name", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            /* Tabelle anlegen 
             * cmd.CommandText = "CREATE TABLE user2(user_id INTEGER PRIMARY KEY, user_name TEXT, password TEXT)";
            cmd.ExecuteNonQuery();
            */
            con.Close();

        }
    }
}
