using HttpClientAndRestSharp_Test;
using HttpClientAndRestSHarp_Test_Instance.ResModel;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Policy;
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

namespace HttpClientAndRestSHarp_Test_Instance.UI
{
    /// <summary>
    /// UserInfo.xaml 的交互逻辑
    /// </summary>
    public partial class UserInfo : UserControl
    {
        private BaseRequest baserequest;

        private RestClient client = new RestClient();
        public UserInfo()
        {
            InitializeComponent();
        }

        private async void clik_GetUsersList(object sender, RoutedEventArgs e)
        {
            baserequest = new BaseRequest()
            {
                Url = "api/users",
                Method = RestSharp.Method.Get,
                Header = new Dictionary<string, string> { { "Content-Type", "application/x-www-form-urlencoded" } },
                Parameter = new Dictionary<string, string> { { "page", "2" } },
                ParameterType = ParameterType.QueryString

            };


            var restClient = new RestClientServices(client);
            var response = await restClient.GetAsync(baserequest);

            //test
            var text = response.GetContext<Res_UeserModel>();
            datadisplay.ItemsSource = text.data;
        }

        private async void clik_GetSingleUser(object sender, RoutedEventArgs e)
        {
            baserequest = new BaseRequest()
            {
                Url = "api/users/{id}",
                Method = RestSharp.Method.Get,
                Header = new Dictionary<string, string> { { "Content-Type", "application/x-www-form-urlencoded" } },
                Parameter = new Dictionary<string, string> { { "id", "2" } },
                ParameterType = ParameterType.UrlSegment
            };
            var restClient = new RestClientServices(client);
            var response = await restClient.GetAsync(baserequest);

            //test
            var text = response.GetContext<SingleUser>();
            var tt = text.data;
            var list = new List<Data>();
            list.Add(tt);
            datadisplay.ItemsSource = list;
            PostShow.Text = tt.last_name;

            //设置定时器
            DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Start();

        }

        private async void click_Register(object sender, RoutedEventArgs e)
        {
            baserequest = new BaseRequest()
            {
                Url = "api/register",
                Method = RestSharp.Method.Post,
                Header = new Dictionary<string, string> { { "Content-Type", "application/json" } },
                Payload = new Dictionary<string, string>
                {
                    {"email","eve.holt@reqres.in" },
                    { "password","pistol"}
                }
            };
            var restClient = new RestClientServices(client);
            var response = await restClient.PostAsync(baserequest);

            //test
            var text = response.GetContext<Register>();
            PostShow.Text = text.token;
        }
    }
}
