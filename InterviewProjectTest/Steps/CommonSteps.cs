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
using System.Diagnostics;

namespace InterviewProjectTest.Steps
{

    [Binding]
    public class CommonSteps
    {
        private readonly ApiSpecTestContext _apiSpecTestContext;
        private RestResponse _restResponse;

        public CommonSteps(ApiSpecTestContext apiSpecTestContext)
        {
            _apiSpecTestContext = apiSpecTestContext;
        }

        [Then(@"a ""(.*)"" response is returned")]
        //[Then(@"a (.*) response is returned")]
        public void ThenResponseIsReturned(int responseCode)
        {
            // get whole response
            var actResponse = _apiSpecTestContext.Response;

            // assert that correct Status is returned
            var actStatusCode = (int)actResponse.StatusCode;
            Debug.WriteLine("Status description: " + actResponse.StatusDescription);
            Assert.AreEqual(responseCode, actStatusCode);
        }

        [Given(@"I am an authenticated user")]
        public void GivenIAmAnAuthenticatedUser()
        {
            /*var accessToken = "ENTER TOKEN HERE";
            _apiSpecTestContext.SetAccessToken(accessToken);

            var jwtAuth = new JwtAuthenticator(_apiSpecTestContext.AccessToken);
            _apiSpecTestContext.SetBaseUrlRestClient(jwtAuth);*/
        }

    }
}
