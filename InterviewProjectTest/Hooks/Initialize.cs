using RestSharp;
using RestSharp.Authenticators;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using InterviewProjectTest.Base;
using InterviewProjectTest.Utilities;
using NUnit.Framework;

namespace InterviewProjectTest.Hooks
{
    [Binding]
    public class Initialize
    {
        private readonly ApiSpecTestContext _apiSpecTestContext;
        private RestResponse _restResponse;

        public Initialize(ApiSpecTestContext apiSpecTestContext)
        {
            _apiSpecTestContext = apiSpecTestContext;
        }

        [BeforeScenario]
        public void BeforeTestRun(ApiSpecTestContext apiSpecTestContext)
        {
   
            _apiSpecTestContext.SetBaseUrl();
        }
    }
}
