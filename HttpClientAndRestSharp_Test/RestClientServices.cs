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
        public static string BASE_URL = "https://reqres.in/";


        public RestClientServices(RestClient client)
        {
            this.client = client;
        }

        public async Task<T> GetAsync<T>(BaseRequest baseRequest) where T : class
        {
            try
            {
                var url = Path.Combine(BASE_URL,baseRequest.Url);
                var method = baseRequest.Method;



                request = new RestRequest(url, method);
                //request.AddHeader("Content-Type", baseRequest.ContentType);
                //var pp = Parameter.CreateParameter("page", 2, ParameterType.QueryString);
                //request.AddParameter(pp);
                request.AddHeaders(new Dictionary<string, string>
            {
                { "Accept", "application/json" },
                { "Content-Type", "application/json" }

            });
                var response = await client.ExecuteAsync(request);
                
                //response.RootElement = "data";
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    
                        return response;
                }
                if (response.ErrorException != null)
                {
                    return response.ErrorException.Message;
                }

                return response.ErrorMessage;
            }
            catch (Exception)
            {

                throw;
            }
           
            

        }

        public async Task<string> PostAsync<T>(BaseRequest baseRequest) where T : class
        {
            try
            {
                var url = Path.Combine(BASE_URL, baseRequest.Url);
                var method = baseRequest.Method;
                var payload= baseRequest.Payload;


                request = new RestRequest(url, method);
                request.AddHeader("Content-Type", "application/json");
                request.AddBody(payload);

                //request.AddParameter(Parameter.CreateParameter("page", 2, ParameterType.QueryString));

                var response = await client.ExecutePostAsync<T>(request);
                //response.RootElement = "data";
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                if (response.ErrorException != null)
                {
                    return response.ErrorException.Message;
                }

                return response.ErrorMessage;
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
