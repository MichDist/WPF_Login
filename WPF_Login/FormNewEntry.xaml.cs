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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Login
{
    /// <summary>
    /// Interaction logic for FormNewEntry.xaml
    /// </summary>
    public partial class FormNewEntry : Page
    {
        public FormNewEntry()
        {
            InitializeComponent();
        }

        private void BtnGeneralEntry_Click(object sender, RoutedEventArgs e)
        {
            EntryFrame.Navigate(new NewGeneralEntryPage());
        }
    }
}
