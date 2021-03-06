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
    /// Interaction logic for SearchEntry.xaml
    /// </summary>
    public partial class SearchEntry : Page
    {
        public SearchEntry()
        {
            InitializeComponent();

            List<Model.Entry> list = new List<Model.Entry>();
            list.Add(new Model.Entry("TEST TEXT 1", "Topic 1", "title 1"));
            list.Add(new Model.Entry("TEST TEXT 2", "Topic 2", "title 2"));
            list.Add(new Model.Entry("TEST TEXT 3", "Topic 3", "title 3"));

            lbEntries.ItemsSource = list;
        }
    }
}
