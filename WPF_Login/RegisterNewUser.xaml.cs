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

namespace WPF_Login
{
    /// <summary>
    /// Interaction logic for RegisterNewUser.xaml
    /// </summary>
    public partial class RegisterNewUser : Window
    {
        public RegisterNewUser()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // Check if pw are the same and not empty
            if((tboxPassword.Text == tboxPasswordRepeat.Text) && tboxPassword.Text != "")
            {
                user newUser = new user(tboxUsername.Text, tboxPassword.Text);
                DB.Database db = new DB.Database(@"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db");

                if(db.userMgt(newUser, "CreateNewUser"))
                {
                    lblMessage.Content = "User created! Closing the window in 3 seconds.";
                    //Continue: https://stackoverflow.com/questions/15599884/how-to-put-delay-before-doing-an-operation-in-wpf
                    this.Close();
                }
                else
                {
                    lblMessage.Content = "Username already exists!";
                }
            }
            else
            {
                lblMessage.Content = "Passwords are different";
            }
  
            
        }
    }
}
