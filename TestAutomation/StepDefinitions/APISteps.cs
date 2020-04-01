using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestAutomation.Models;

namespace TestAutomation.StepDefinitions
{
   [Binding]
   public class APISteps
    {
        #region Define Public Variables
        public static RestClient api = new RestClient("https://jsonplaceholder.typicode.com/");
        public static RestRequest request;
        public static IRestResponse apiResult;
        private static UserContent user_info;
        #endregion

        [Given(@"Create URL segment for (.*) with GET method")]
        public void GivenCreateURLSegmentForWithGETMethod(string p0)
        {
            request = new RestRequest("/posts/{Id}", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("Id", p0);

        }

        [When(@"Execute API")]
        [When(@"Deserialize the user api content")]
        public void WhenExecuteAPI()
        {
            apiResult = api.Execute(request);
        }

     
        [Then(@"returned status code will be (.*)")]
        public void ThenReturnedStatusCodeWillBe(string p0)
        {
            var code = apiResult.StatusCode;
            Assert.That(code.ToString().Equals(p0), "Status code is not equal to{0}", p0);
            
        }

        [Then(@"response should return valid (.*) , (.*), (.*)")]
        public void ThenResponseShouldReturnValid(string p0, string p1, string p2)
        {
         
            JObject user_obs = JObject.Parse(apiResult.Content);
            string body = user_obs["body"].ToString();
            Assert.That(user_obs["userId"].ToString().Equals(p0), "Reponse does not contain,{0}", p0);
            Assert.That(user_obs["title"].ToString().Equals(p1), "Reponse does not contain,{0}", p1);
            //Assert request body
        }

    }
}
