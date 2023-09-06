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

namespace _10_DataView
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

        private readonly S_InfoDbConText db = new S_InfoDbConText();
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            BindDrp();
            GetData();


        }

        protected void BindDrp()
        { 
        List<ProvinceInfo> list=db.ProvinceInfo.ToList<ProvinceInfo>();
            sinfoProvince.ItemsSource = list;

        
        }
        protected void GetData()
        {
            List<S_Info> lists = db.S_Info.ToList<S_Info>();

            gridSinfos.ItemsSource = lists;

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            S_Info info = (S_Info)gridSinfos.SelectedItem;
            info.UpdateTime = DateTime.Now;
            //S_Info? modifyInfo = db.S_Info.Find(info.ContactID);
            //modifyInfo = info;

            txtMsg.Text = "save success!";
            
            
            
            db.SaveChanges();

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
