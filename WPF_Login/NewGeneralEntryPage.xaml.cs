using Serilog;
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
    /// Interaction logic for NewGeneralEntryPage.xaml
    /// </summary>
    public partial class NewGeneralEntryPage : Page
    {
        public NewGeneralEntryPage()
        {
            InitializeComponent();

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("C:\\Users\\Michael Distler\\source\\repos\\logs_wpf\\log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Log.Information("Start: Initialize topic combobox with data");
            DB.Database db = new DB.Database(@"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db");

            cbTopic.ItemsSource = db.getTopics();

            
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //Log.Debug("Combobox: " + cbTopic.Text);
            //Log.Debug("Combobox: " + cbTopic.SelectedIndex);
            //Log.Debug("Combobox: " + cbTopic.SelectedItem);
            //Log.Debug("Combobox: " + cbTopic.SelectedValue);
            //Log.Debug("Combobox: " + cbTopic.SelectionBoxItem);
            //Log.Debug("Textfeld: " + txtBoxTopic.Text);

            // Create new entry and fill it with data
            Model.Entry entry = new Model.Entry();
            user curUser = (user)App.Current.Properties["currentUser"];
            entry.user_id = curUser.getID();
            entry.typeId = 1;   // General Entry, see Database 
            entry.title = txtBoxTitle.Text;
            entry.entry_abstract = txtBoxDescription.Text;
            // Content
            // Topic
            if(txtBoxTopic.Text == null || txtBoxTopic.Text == "")
            {
                entry.topic = cbTopic.Text;
                Log.Debug("Combobox topic: " + cbTopic.Text);
            }
            else
            {
                entry.topic = txtBoxTopic.Text;
                Log.Debug("Textbox topic: " + txtBoxTopic.Text);
            }
            entry.topicId = 0;
            // Tags - später machen !!!!!!!

            // Save - Check if successful and notify user !!!!!!
            DB.Database db = new DB.Database(@"URI=file:C:\Users\Michael Distler\source\repos\WPF_Login\test.db");
            db.saveEntry(entry);
        }
    }
}
