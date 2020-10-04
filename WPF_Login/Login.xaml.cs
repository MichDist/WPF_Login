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
using Serilog;

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

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("C:\\Users\\Michael Distler\\source\\repos\\logs_wpf\\log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            user loginUser = new user(txtUsername.Text, txtPassword.Text);

            DB.Database db = new DB.Database(@"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db");

            // Test log
            Log.Debug("Button clicked");

            // Check if user exists
            if(db.userMgt(loginUser, "CheckUserNameExists"))
            {
                // Check if password is correct
                if(db.userMgt(loginUser, "CheckUserPW"))
                {
                    // Navigate to main window and save current user and get user data from db
                    loginUser = db.getUserData(loginUser);
                    App.Current.Properties["currentUser"] = loginUser;
                    var newWindow = new MainWindow();
                    this.Close();
                    newWindow.Show();
                }
                else
                {
                    lblPasswordCheck.Content = "Password is wrong!";
                }
            }
            else
            {
                lblPasswordCheck.Content = "User does not exist!";
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
            //con.Close();

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new RegisterNewUser();
            newWindow.Show();
        }
    }
}
