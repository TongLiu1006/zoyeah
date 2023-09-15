using HttpClientAndRestSharp_Test;
using HttpClientAndRestSHarp_Test_Instance.TestModel.ResponseModel;
using RestSharp;
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

namespace HttpClientAndRestSHarp_Test_Instance.UI
{
    /// <summary>
    /// SmartDetection.xaml 的交互逻辑
    /// </summary>
    public partial class SmartDetection : UserControl
    {
        private BaseRequest baserequest;

        private RestClient client = new RestClient();
        public SmartDetection()
        {
            InitializeComponent();
        }

        private async void click_GetCurveInfo(object sender, RoutedEventArgs e)
        {
            baserequest=new BaseRequest() 
            {
                Method = Method.Get,
                Url= "minor-radius-curve/curve/list",
                Header=new Dictionary<string, string> { { "Content-Type", "application/x-www-form-urlencoded" } },
                Parameter=new Dictionary<string, string>
                {
                    {"lineName","京九" },
                    {"rowType","下" }
                },
                ParameterType=ParameterType.QueryString
                
            };

           var restClientServices= new RestClientServices(client, "http://47.122.7.96:8010/");
            var response=await restClientServices.GetAsync(baserequest);
            var tt= response.GetContext<CurveInfo_Data>();
            curveinfoui.ItemsSource = tt.data;
        }
    }
}
