using APIAutomation;
using APIAutomation.Models.Request;
using APIAutomation.Models.Respones;
using APIAutomation.Utility;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class CreateUserStepDefinitions
    {

        private CreateUserReq createUserReq;
        private RestResponse response;
        private ScenarioContext scenarioContext;
        private HttpStatusCode statusCode;
        private APIClient api;
        private const string BASE_URL = "https://reqres.in/";

        public CreateUserStepDefinitions(CreateUserReq createUserReq,ScenarioContext scenarioUsercontext)
        {
            this.createUserReq = createUserReq;
            this.scenarioContext = scenarioUsercontext;
             this.api = new APIClient();
        }



        [Given(@"\[payload""([^""]*)""]")]
        public void GivenPayload(string filename)
        {
            string file = HandlerContext.GetFilePath(filename);
            var payload = HandlerContext.ParseJson<CreateUserReq>(file);
            // if we want to update Json file after read ,and then it will passed to
            //request as payload
            //payload.name = filename;
            //payload.job = filename;


            //use scenario to share data to next step
            scenarioContext.Add("createUser_payload", payload);
        }





        [When(@"\[request]")]
        public async Task WhenRequest()
        {
          createUserReq= scenarioContext.Get<CreateUserReq>("createUser_payload");
            response = await api.CreateUser<CreateUserReq>(BASE_URL,createUserReq);
            
        }

        [Then(@"\[validate]")]
        public void ThenValidate()
        {
            statusCode = response.StatusCode;
            var code=(int) statusCode;
            Assert.AreEqual(201,code);

            var context = HandlerContext.GetContext<CreateUserRes>(response);
            Assert.AreEqual(createUserReq.name,context.name);
            Assert.AreEqual(createUserReq.job,context.job);
        }
    }
}
