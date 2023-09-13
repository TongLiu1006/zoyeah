using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;
using Polly;
using RestSharp;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SmartDetection.https
{
    public class RestSharpService : IHttpService
    {
        private readonly RestClient _client;
        private int _maxRetryAttempts = 2;//重试次数
        private double _pauseBetweenFailuresSecond = 1d;  //失败后的暂停多久重试 单位s

        public RestSharpService(RestClient restClient)
        {
            _client = restClient;
        }

        public async Task<string> ExecuteAsync(BaseRequest baseRequest)
        {
            try
            {
                if (string.IsNullOrEmpty(baseRequest.Url))
                {
                    return "Url is Empty";
                }
                var url = new Uri(baseRequest.Url);
                var request = new RestRequest(url, baseRequest.Method);
                request.AddHeader("Content-Type", baseRequest.ContentType);
                var param = JsonConvert.SerializeObject(baseRequest.Parameter);
                if (baseRequest.Parameter != null)
                {
                    request.AddParameter("application/json", param, ParameterType.RequestBody);
                }

                var response = await RestResponseWithPolicyAsync(request);

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
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 使用Policy执行http请求
        /// </summary>
        /// <param name="restRequest"></param>
        /// <returns></returns>
        private Task<RestResponse> RestResponseWithPolicyAsync(RestRequest restRequest)
        {
            var retryPolicy = Policy
                .HandleResult<RestResponse>(x => !x.IsSuccessful)
                .WaitAndRetryAsync(_maxRetryAttempts, x => TimeSpan.FromSeconds(_pauseBetweenFailuresSecond), (restResponse, timeSpan, retryCount, context) =>
                {
                    Console.WriteLine($"The request failed. HttpStatusCode={restResponse.Result.StatusCode}. " +
                        $"\nWaiting {timeSpan.TotalSeconds} seconds before retry. Number attempt {retryCount}." +
                        $"\n Uri={restResponse.Result.ResponseUri}; " +
                        $"\nRequestResponse={restResponse.Result.Content}"
                        + $"\nErrorMessage={restResponse.Result.ErrorMessage}");
                });

            var circuitBreakerPolicy = Policy
                .HandleResult<RestResponse>(x => x.StatusCode == HttpStatusCode.ServiceUnavailable)
                .CircuitBreakerAsync(1, TimeSpan.FromSeconds(60), onBreak: (restResponse, timespan, context) =>
                {
                    Console.WriteLine($"Circuit went into a fault state. Reason: {restResponse.Result.Content}");
                },
                onReset: (context) =>
                {
                    Console.WriteLine($"Circuit left the fault state.");
                });

            return retryPolicy.WrapAsync(circuitBreakerPolicy).ExecuteAsync(() => _client.ExecuteAsync(restRequest));
        }

        public async Task<TResponse> GetAsync<TResponse>(string url) where TResponse : class
        {
            var text = await ExecuteAsync(new BaseRequest()
            {
                Url = url,
                Method = Method.Get,
            });
            return (typeof(TResponse) == typeof(string)) ? ((text as TResponse)) : (ToJsonModel<TResponse>(text));
        }

        public async Task<TResponse> PostAsync<TResponse>(string url, object param) where TResponse : class
        {
            var text = await ExecuteAsync(new BaseRequest()
            {
                Url = url,
                Method = Method.Post,
                Parameter = param
            });
            return (typeof(TResponse) == typeof(string)) ? ((text as TResponse)) : (ToJsonModel<TResponse>(text));
        }

        public T ToJsonModel<T>(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return default(T);
            }

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            //   jsonSerializerOptions.Converters.Add(new DateTimeConverterUsingDateTimeParse());
            return JsonSerializer.Deserialize<T>(json, jsonSerializerOptions);
        }
    }
}
