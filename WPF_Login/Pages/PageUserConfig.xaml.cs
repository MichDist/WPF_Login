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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Login.Pages
{
    /// <summary>
    /// Interaction logic for PageUserConfig.xaml
    /// </summary>
    public partial class PageUserConfig : Page
    {
        public PageUserConfig()
        {
            InitializeComponent();
        }

        private void btnNewUserName_Click(object sender, RoutedEventArgs e)
        {
            user currentUser = (user)App.Current.Properties["currentUser"];

            currentUser.setName(tboxNewUserName.Text);

            DB.Database db = new DB.Database(@"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db");

            db.userMgt(currentUser, "ChangeUsername"); // SPÄTER MIT UNTEN STEHENDEN ERSETZEN
            //if(db.userMgt(currentUser, "ChangeUsername"))
            //{
            //    MELDUNG ÜBER NEUES LABEL
            //}
        }

        private void btnNewPassword_Click(object sender, RoutedEventArgs e)
        {
            user currentUser = (user)App.Current.Properties["currentUser"];

            currentUser.setPassword(tboxNewPassword.Text);

            DB.Database db = new DB.Database(@"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db");

            db.userMgt(currentUser, "ChangePassword"); // SPÄTER ERSETZEN
            //if(db.userMgt(currentUser, "ChangeUsername"))
            //{
            //    MELDUNG ÜBER NEUES LABEL
            //}
        }
    }
}
