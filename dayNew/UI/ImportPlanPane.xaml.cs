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
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Net.Http.Headers;
using Microsoft.SqlServer.Server;
using SmartDetection.UI.components.importPlanCom;

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

        /*public void GetViewUrl(IFormFile file)
        {
            using (var client = new HttpClient())
            {
                //将文件转成流
                var stream = file.OpenReadStream();

                //请求体构建
                var content = new MultipartFormDataContent();
                content.Add(new StreamContent(stream), "file", file.FileName);

                //发送请求
                var response = client.PostAsync("url", content);

                //请求成功，读取结果
                if (response.Result.StatusCode == HttpStatusCode.OK)
                {
                    var result = response.Result.Content.ReadAsStringAsync().Result;
                    //其他操作...
                }
            }
        }*/



        private void importPlan(object sender, RoutedEventArgs e)
        {
            try
            {
                importPlanPane.Children.Clear();
                importPlanPane.Children.Add(new UploadPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void click_taskPlan(object sender, RoutedEventArgs e)
        {
            try
            {
                importPlanPane.Children.Clear();
                importPlanPane.Children.Add(new TaskAssignment());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


        private void click_toDetailPage(object sender, RoutedEventArgs e)
        {
            try
            {
                importPlanPane.Children.Clear();
                importPlanPane.Children.Add(new detailPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private async void importPlan_(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool? res = openFileDialog.ShowDialog();
            if (res == true)
            {
                string fileName = openFileDialog.FileName.ToString();

                // 读取文件
                /*Stream fileStream = new FileStream(@"C:\Users\webuild微筑\Desktop\微信图片_20230906162407.png", FileMode.Open, FileAccess.Read);
                // 实例化multipart表单模型
                var formData = new MultipartFormDataContent();
                // 设定文本类型表单项，使用StringContent存放字符串
                formData.Add(new StringContent("damage_analyse_image"), "bizType");
                // 设定文件类型表单项，使用StreamContent存放文件流
                formData.Add(new StreamContent(fileStream), "file", "a.png");

                // 实例化HttpClient
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Token", "eyJhbGciOiJIUzI1NiJ9.eyJpZCI6MTAyLCJyb2xlIjoiY29tbW9uIiwidXNlck5hbWUiOiJsaWthaSIsImxvZ2luTmFtZSI6Imxpa2FpIiwiaWF0IjoxNjk0MDUzNzc4LCJleHAiOjE2OTUyNjMzNzh9.1Ra2-ZQ-Fqewr2t6S9ejm4HvnEQDEDmYkHT--iXaavw");

                // 发送请求
                HttpResponseMessage result = client.PostAsync("http://47.122.7.96:8010/upload", formData).Result;
                // 接受结果
                string responseResult = result.Content.ReadAsStringAsync().Result;
                // 打印结果
                Console.WriteLine(responseResult);
                client.Dispose();
                fileStream.Close();*/

                // 创建一个HttpClient对象：
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Accept", "*/*");
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36");
                client.DefaultRequestHeaders.Add("X-Token", "eyJhbGciOiJIUzI1NiJ9.eyJpZCI6MTAyLCJyb2xlIjoiY29tbW9uIiwidXNlck5hbWUiOiJsaWthaSIsImxvZ2luTmFtZSI6Imxpa2FpIiwiaWF0IjoxNjk0MDUzNzc4LCJleHAiOjE2OTUyNjMzNzh9.1Ra2-ZQ-Fqewr2t6S9ejm4HvnEQDEDmYkHT--iXaavw");
                // 创建一个MultipartFormDataContent对象，用于构建包含文件的多部分表单数据：
                MultipartFormDataContent formData = new MultipartFormDataContent();
                // 实例化一个FileStream对象，用于读取要上传的文件内容：
                FileStream fileStream = new FileStream(fileName, FileMode.Open);
                // 创建一个StreamContent对象，并将FileStream对象作为参数传递给它：
                StreamContent fileContent = new StreamContent(fileStream);
                //var fileContent = new ByteArrayContent(System.IO.File.ReadAllBytes(@"C:\Users\webuild微筑\Desktop\微信图片_20230906162407.png"));

                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
                // 将StreamContent对象添加到MultipartFormDataContent对象中，并指定表单字段名称和文件名

                formData.Add(new StringContent("damage_analyse_image"), "bizType");

                formData.Add(fileContent, "files", "222.png");

                HttpResponseMessage response = client.PostAsync("http://47.122.7.96:8010/upload", formData).Result;

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
