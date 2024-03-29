﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomation
{
    public class APIClient : IAPIClient, IDisposable
    {
        readonly RestClient client;
        const string BASE_URL = "https://reqres.in/";
        public APIClient()
        {
            var options = new RestClientOptions(BASE_URL)
            {
                Authenticator = new APIAuthenticator()
            };
            client = new RestClient(options);
            
        }
        public async Task<RestResponse> CreateUser<T>(string baseUrl,T payload) where T : class
        {

            var url = Path.Combine(baseUrl, Endpoints.CREATE_USER);
            var client = new RestClient(url);

            var request = new RestRequest()
            {
                Method = Method.Post
            };
            request.AddHeader("Accept", "application/json");
            request.AddBody(payload);
            //request.AddParameter("Content-Type", "application/json");
           
            request.RequestFormat=DataFormat.Json;
            var response=await client.ExecuteAsync<T>(request);
            return response;
        }

        public async Task<RestResponse> DeleteUser(string id)
        {
            var request=new RestRequest(Endpoints.DELETE_USER,Method.Delete);
            request.AddUrlSegment(id,id);
            return await client.ExecuteAsync(request);
        }

        public void Dispose()
        {
            client?.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<RestResponse> GetListofUser(int pageNumber)
        {
            var request = new RestRequest(Endpoints.GET_LIST_OF_USERS, Method.Get);
            request.AddQueryParameter("page", pageNumber);
            return await client.ExecuteAsync(request);
        }

        public async Task<RestResponse> GetUser(string id)
        {
            var request = new RestRequest(Endpoints.GET_USER, Method.Get);
          request.AddUrlSegment($"{id}", id);
            return await client.ExecuteAsync(request);
        }

        public async Task<RestResponse> UpdateUser<T>(T payload, string id) where T : class
        {
            var request = new RestRequest(Endpoints.GET_USER, Method.Put);
            request.AddUrlSegment($"{id}", id);
            request.AddBody(payload);
            return await client.ExecuteAsync<T>(request);
        }

        public Task<RestResponse> CreateUser<T>(T payload) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
