using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using APIAutomation.Models.Respones;
using RestSharp;
using RestSharp.Authenticators;

namespace APIAutomation
{
    public class APIAuthenticator:AuthenticatorBase
    {

        readonly string baseUrl;
        readonly string clinetId;
        readonly string clientSecret;

        public APIAuthenticator():base("")
        {
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            var token = string.IsNullOrEmpty(Token)?await GetToken():Token;
            return new HeaderParameter(KnownHeaders.Authorization,token);
            
        }

        private async Task<string> GetToken()
        {
            var options = new RestClientOptions(baseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(clinetId,clientSecret),
            };
            var client = new RestClient(options);
            var request = new RestRequest("oauyh2/token")
                .AddParameter("grant_type","client_credenatials");
            var response = await client.PostAsync<TokenResponse>(request);
            return $"{response.TokenType}{response.AccessToken}";
            
        
        }

     
    }
}
