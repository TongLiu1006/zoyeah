using _09_ListViewExample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace _09_ListViewExample
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

        TestDbConText db =new TestDbConText();
        

        private void btnRefrsh_Click(object sender, RoutedEventArgs e)
        {
            GetData();
            Console.WriteLine(db.S_info.First().Firstname);

        }




        protected void GetData()
        { 
        List<S_Info> list = db.S_info.ToList<S_Info>();
            listView1.ItemsSource = list;
            
            
        
        }
    }
}
