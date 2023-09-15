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
using System.Windows.Threading;
using HttpClientAndRestSharp_Test;
using HttpClientAndRestSHarp_Test_Instance.ResModel;
using HttpClientAndRestSHarp_Test_Instance.UI;
using Newtonsoft.Json;
using RestSharp;

namespace HttpClientAndRestSHarp_Test_Instance
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

    
        private void GetIntoUserTest(object sender, MouseButtonEventArgs e)
        {
            
            itemPane.Children.Clear();
            itemPane.Children.Add(new UserInfo());
        }

        private void GetIntoSmartDectionTest(object sender, MouseButtonEventArgs e)
        {
            itemPane.Children.Clear();
            itemPane.Children.Add(new SmartDetection());
        }
    }
}
