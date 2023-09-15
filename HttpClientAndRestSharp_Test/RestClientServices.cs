using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace HttpClientAndRestSharp_Test
{
    public class RestClientServices
    {
        private RestClient client;
        private RestRequest request;
        private string BASE_URL = "https://reqres.in/";


        public RestClientServices(RestClient client,string baseurl= "https://reqres.in/")
        {
            this.client = client;
            this.BASE_URL = baseurl;
        }

        public async Task<RestResponse> GetAsync(BaseRequest baseRequest)
        {
            try
            {
                //get data from base request
                var url = Path.Combine(BASE_URL, baseRequest.Url);
                var method = baseRequest.Method;
                var header = baseRequest.Header;
                var param = baseRequest.Parameter;
                var paramType = baseRequest.ParameterType;

                //set baserequest data into restrequest
                request = new RestRequest(url, method);
                request.AddHeaders(header);

                if (param!=null)
                {
                    foreach (var item in param)
                    {
                        request.AddParameter(item.Key, item.Value, paramType);
                    }
                }

            }
            catch (Exception)
            { }
            return await client.ExecuteAsync(request);

        }

        public async Task<RestResponse> PostAsync(BaseRequest baseRequest)
        {
            try
            {
                //get data from base request
                var url = Path.Combine(BASE_URL, baseRequest.Url);
                var method = baseRequest.Method;
                var header = baseRequest.Header;
                var param = baseRequest.Parameter;
                var paramType = baseRequest.ParameterType;
                var payload = baseRequest.Payload == null ? null : baseRequest.Payload;
                //set baserequest data into restrequest
                request = new RestRequest(url, method);
                request.AddHeaders(header);

                
                if (param!=null)
                {
                    foreach (var item in param)
                    {
                        request.AddParameter(item.Key, item.Value, paramType);
                    }
                }
                //payload need user dataJson to Parse data Json Model
                if (payload != null) request.AddBody(payload);
            }
            catch (Exception)
            { }
      
              return await client.ExecuteAsync(request);
        }

    }

}
