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

           return JsonConvert.DeserializeObject<T>(context);

        }
    }
}
