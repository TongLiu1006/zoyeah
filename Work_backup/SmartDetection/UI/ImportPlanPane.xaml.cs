using SmartDetection.biz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;
using SmartDetection.dataType;
using System.Runtime.InteropServices;
using System.Windows.Markup;
using Microsoft.Win32;

namespace SmartDetection.UI
{
    /// <summary>
    /// ImportPlanPane.xaml 的交互逻辑
    /// </summary>
    public partial class ImportPlanPane : UserControl
    {
        public ImportPlanPane()
        {
            InitializeComponent();
            List<PlanData> pData = new List<PlanData>();
            for (int i = 0; i < 10; i++)
            {
                PlanData planData = new PlanData();
                planData.id = "1" + i;
                pData.Add(planData);
            }
            PlanDataList.ItemsSource = pData;
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void importPlan(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool? res = openFileDialog.ShowDialog();
            if (res == true)
            {
                MessageBox.Show(openFileDialog.FileName.ToString());
            }
        }

        private void queryPlan(object sender, RoutedEventArgs e)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp("http://47.122.7.96:8010/task-damage-info/list?damageType=3&pageNum=1&pageSize=10");
                request.Method = "GET";
                request.AutomaticDecompression = DecompressionMethods.GZip;

                request.ContentType = "application/x-www-form-urlencoded";

                request.UserAgent = "Mozilla/5.0(Windows NT 10.0;Win64;x64) AppleWebKit/537.36(KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36";
                request.Accept = "*/*";
                request.Headers.Set("Accept-Language", "zh-CN,zh;q=0.9");


                WebResponse res = request.GetResponse();

                using (StreamReader reader = new StreamReader(res.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    RootObject data_ = JsonConvert.DeserializeObject<RootObject>(result);

                    List<Row> pData = new List<Row>();
                    int length = data_.data.rows.Count;

                    for (int i = 0; i < length; i++)
                    {
                        pData.Add(data_.data.rows[i]);
                    }

                    PlanDataList.ItemsSource = pData;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // 获取上行下行数据
            HttpWebRequest request = WebRequest.CreateHttp("http://47.122.7.96:8010/system/dict/ts_row_type");
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.GZip;

            request.ContentType = "application/x-www-form-urlencoded";

            request.UserAgent = "Mozilla/5.0(Windows NT 10.0;Win64;x64) AppleWebKit/537.36(KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36";
            request.Accept = "*/*";
            request.Headers.Set("Accept-Language", "zh-CN,zh;q=0.9");

            WebResponse res = request.GetResponse();

            using (StreamReader reader = new StreamReader(res.GetResponseStream()))
            {
                string result = reader.ReadToEnd();
                listUpDownRow dataList = JsonConvert.DeserializeObject<listUpDownRow>(result);
                List<RowUpDownType> list = new List<RowUpDownType>();

                int length = dataList.data.Count;
                for (int i = 0; i < length; i++)
                {
                    list.Add(dataList.data[i]);
                }

                city_combobox.ItemsSource = list;
            }


            // 获取线名数据
            HttpWebRequest request_line = WebRequest.CreateHttp("http://47.122.7.96:8010/system/dict/ts_line_name");
            request_line.Method = "GET";
            request_line.AutomaticDecompression = DecompressionMethods.GZip;

            request_line.ContentType = "application/x-www-form-urlencoded";

            request_line.UserAgent = "Mozilla/5.0(Windows NT 10.0;Win64;x64) AppleWebKit/537.36(KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36";
            request_line.Accept = "*/*";
            request_line.Headers.Set("Accept-Language", "zh-CN,zh;q=0.9");

            WebResponse res_line = request_line.GetResponse();

            using (StreamReader reader_line = new StreamReader(res_line.GetResponseStream()))
            {
                string result = reader_line.ReadToEnd();
                listUpDownRow dataList = JsonConvert.DeserializeObject<listUpDownRow>(result);
                List<RowUpDownType> list = new List<RowUpDownType>();

                int length = dataList.data.Count;
                for (int i = 0; i < length; i++)
                {
                    list.Add(dataList.data[i]);
                }

                line_name_combobox.ItemsSource = list;
            }

        }
    }
}
