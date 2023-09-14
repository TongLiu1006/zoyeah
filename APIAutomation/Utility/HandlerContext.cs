using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace APIAutomation.Utility
{
    public class HandlerContext
    {
        public static T GetContext<T>(RestResponse response)
        {

            var context = response.Content;

            var obj=JsonConvert.DeserializeObject<T>(context);
            return obj;

        }

        public static T ParseJson<T>(string file)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }

        public static string GetFilePath(string name)
        {
           
            string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            path=string.Format(path+"TestData\\{0}",name);
            return path;
        }
    }
}
