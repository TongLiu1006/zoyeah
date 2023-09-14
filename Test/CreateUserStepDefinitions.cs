using System;
using System.Diagnostics;
using System.Net;
using APIAutomation;
using APIAutomation.Models.Request;
using APIAutomation.Utility;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class CreateUserStepDefinitions
    {
        private CreateUserReq createUserReq;
        private RestResponse restResponse;
        private ScenarioContext scenarioContext;
        private HttpStatusCode statucode;

        public CreateUserStepDefinitions(CreateUserReq createUserReq,  ScenarioContext scenarioContext)
        {
            this.createUserReq = createUserReq;
            this.scenarioContext = scenarioContext;
        }


        [Given(@"\[name]")]
        public void GivenName(string name)
        {
            createUserReq.name= name;
        }

        [Given(@"\[job]")]
        public void GivenJob(string job)
        {
            createUserReq.job = job;
        }

        [When(@"\[request]")]
        public async Task WhenRequest()
        {
            var api = new APIClient();
            restResponse = await api.CreateUser<CreateUserReq>(createUserReq);
        }

        [Then(@"\[validate]")]
        public void ThenValidate()
        {
           statucode= restResponse.StatusCode;
           var code =(int)statucode;
            Assert.AreEqual(201,code);

            var context = HandlerContext.GetContext<CreateUserReq>(restResponse);

            //Assert.IsNotNull(context);
            Assert.AreEqual(createUserReq.name,context.name);
            Assert.AreEqual(createUserReq.job,context.job);
        }
    }
}
