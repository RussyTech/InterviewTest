using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using InterviewProjectTest.Base;
using InterviewProjectTest.Utilities;
using NUnit.Framework;

namespace InterviewProjectTest.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly ApiSpecTestContext _apiSpecTestContext;
        private RestResponse _restResponse;

        public LoginSteps(ApiSpecTestContext apiSpecTestContext)
        {
            _apiSpecTestContext = apiSpecTestContext;
        }

        [Given(@"I perform a POST request to the ""(.*)"" endpoint to login with Table")]
        public async Task GivenIPerformAPOSTRequestToTheEndpointToLoginWithTable(string url, Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _apiSpecTestContext.AddRequest(url, Method.Post);
            _apiSpecTestContext.Request.RequestFormat = DataFormat.Json;
            _apiSpecTestContext.Request.AddBody(new { username = (string)data.UserName, password = (string)data.Password });
            await _apiSpecTestContext.GetResponse();
        }

    }

}
