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
using HttpClientAndRestSharp_Test;
using RestSharp;

namespace HttpClientAndRestSHarp_Test_Instance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseRequest baserequest;

        private RestClient client=new RestClient();
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void clik_test(object sender, RoutedEventArgs e)
        { 
            baserequest = new BaseRequest()
            {
                Url = "api/user/2",
                Method=RestSharp.Method.Get

            };


            var restClient=new RestClientServices(client);
            var content=restClient.GetAsync<RestResponse>(baserequest);

            
            //var re = content.Result;
            //text.Text = content.Result;
        }
    }
}
