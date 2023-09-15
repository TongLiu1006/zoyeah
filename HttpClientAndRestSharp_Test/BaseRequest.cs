using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace HttpClientAndRestSharp_Test
{
    public class BaseRequest
    {
        public int TimeOut { get; set; } = 300;
        public Method Method { get; set; }
        public string Url { get; set; }
        public string ContentType { get; set; } = "application/x-www-form-urlencoded";

        public Parameter Parameter { get; set; }

        public object Payload { get; set; }
       
        


    }
}
