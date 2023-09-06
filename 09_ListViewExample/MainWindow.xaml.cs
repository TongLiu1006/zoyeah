using _09_ListViewExample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace _09_ListViewExample
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        
        public List<S_Info> List { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        private readonly  TestDbConText db = new TestDbConText();

       

        private void btnRefrsh_Click(object sender, RoutedEventArgs e)
        {
            GetData();
          

        }




        protected void GetData()
        {
            List = db.S_info.ToList<S_Info>();
            listView1.ItemsSource = List;



        }

        private void btn_UpdateData(object sender, RoutedEventArgs e)
        {
            int contactid = int.Parse(textBox_ContackID.Text);
            var info = db.S_info.Where(cid => cid.ContactID == contactid).OrderBy(cid=>cid.ContactID).FirstOrDefault();
            info.FirstName = textBox_FirstName.Text;
            info.LastName = textBox_LastName.Text;
            info.EmailAddress = textBox_EmailAddress.Text;
            db.SaveChanges();


        }
    }
}
