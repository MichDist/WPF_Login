using System;
using System.Collections.Generic;
using System.Data.SQLite;
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

namespace WPF_Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new Home());
        }

        private void BtnCreateNewEntry_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FormNewEntry());
        }

        private void BtnSearchEntry_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SearchEntry());           
        }

        private void BtnCloseApplication_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TextBlock_Initialized(object sender, EventArgs e)
        {
            user curUser = (user) App.Current.Properties["currentUser"];
            currentUser.Text = currentUser.Text + curUser.getName();
            //currentUser.Text = currentUser.Text + App.Current.Properties["currentUser"].ToString();
            // Date ??

            // How to pass data between windows?
            //string cs = @"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db";
            //var con = new SQLiteConnection(cs);
            //con.Open();
            //var cmd = new SQLiteCommand(con);

            //cmd.CommandText = "SELECT user_name FROM temp.CURRENT_USER ";
            //cmd.Prepare();

            //SQLiteDataReader rdr = cmd.ExecuteReader();

            //while (rdr.Read())
            //{
            //    currentUser.Text = rdr.GetString(0);
            //}

            //rdr.Close();
            //con.Close();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Home());
        }

        private void BtnExportImport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTasks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUserConfig_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.PageUserConfig());
        }
    }
}
