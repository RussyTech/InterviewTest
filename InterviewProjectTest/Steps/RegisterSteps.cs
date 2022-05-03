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
    public class RegisterSteps
    {
        private readonly ApiSpecTestContext _apiSpecTestContext;
        private RestResponse _restResponse;

        public RegisterSteps(ApiSpecTestContext apiSpecTestContext)
        {
            _apiSpecTestContext = apiSpecTestContext;
        }

        [Given(@"I perform a POST request to the ""(.*)"" endpoint with Table")]
        public async Task GivenIPerformAGETRequestForWithBody(string url, Table table)
        {
            //_apiSpecTestContext.SetBaseUrl();
            dynamic data = table.CreateDynamicInstance();
            _apiSpecTestContext.AddRequest(url, Method.Post);
            _apiSpecTestContext.Request.RequestFormat = DataFormat.Json;
            _apiSpecTestContext.Request.AddBody(new { username= (string)data.UserName, email = (string)data.Email, password = (string)data.Password });
            await _apiSpecTestContext.GetResponse();
        }

        [Then(@"I confirm the ""(.*)"" field is ""(.*)""")]
        public void ThenIConfirmTheFieldIs(string message, string value)
        {
            Assert.That(_apiSpecTestContext.Response.GetResponseObject(message), Is.EqualTo(value), $"The {message} is not correct");
        }


        [Then(@"I peform a POST request to the ""(.*)"" endpoint to delete newly created user")]
        public async Task ThenIPeformAPOSTRequestToTheEndpointToDeleteNewlyCreatedUser(string url, Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _apiSpecTestContext.AddRequest(url, Method.Post);
            _apiSpecTestContext.Request.RequestFormat = DataFormat.Json;
            _apiSpecTestContext.Request.AddBody(new { username = (string)data.UserName });
            await _apiSpecTestContext.GetResponse();
        }
    }
}
