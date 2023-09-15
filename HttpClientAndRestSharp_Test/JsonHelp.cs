using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace HttpClientAndRestSharp_Test
{
    public static class JsonHelp
    {

        public static T GetContext<T>(RestResponse response)
        {
            var context = response.Content;
            return JsonConvert.DeserializeObject<T>(context);
        }

        public static T ParseJson<T>(string filepath)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filepath));
        }


        public static string SerializeJsonString(dynamic context)
        {
            return JsonConvert.SerializeObject(context,Formatting.Indented);
        }
    }
}
