using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SmartDetection.https
{
    public class TestHttp
    {
        public void test()
        {
            var service = new RestSharpService(new RestClient());
            var url = "http://api.k780.com/?app=life.time&appkey=10003&sign=b59bc3ef6191eb9f747dd4e83c99f2a4&format=json";
            Task<string> r = service.GetAsync<string>(url);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
