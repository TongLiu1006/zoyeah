using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
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

namespace SmartDetection.UI.components.importPlanCom
{
    /// <summary>
    /// UploadPage.xaml 的交互逻辑
    /// </summary>
    public partial class UploadPage : UserControl
    {
        public UploadPage()
        {
            InitializeComponent();
        }

        private void importPlan(object sender, RoutedEventArgs e)
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
    }
}
