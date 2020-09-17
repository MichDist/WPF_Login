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
        }

        private void BtnCreateNewEntry_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EntryTypeOverview());
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
            // How to pass data between windows?
            user usr2 = new user("SomeName", "PW");
            
            currentUser.Text = "currentUser: " + usr2.getName();
        }
    }
}
