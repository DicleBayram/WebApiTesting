using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Stylelabs.MQA.WebApiTesting.Entities;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace Stylelabs.MQA.WebApiTesting.Tests
{
    [TestFixture]
    [Binding, Scope(Feature = "WeatherMap")]

    public class WeatherMap
    {
        const double kelvinConstant = 273.15;
              
        [StepDefinition(@"'(.*)' with id '(.*)' and appId '(.*)' and the max_temperature should be bigger than '(.*)' Celsius")]
        public void ControlResult(string url, string Id, string appId, string degree)
        {
            var actualResult = ApiResponse.GetResponse(url + Id + appId);
            int expectedResult = Convert.ToInt32(degree);
            var actualMax = actualResult.list.First(p => p.dtDateTime.Date.Equals(DateTime.Now.Date.AddDays(1))).main.temp_max;
            var actualMaxInCelcius = actualMax - kelvinConstant;
            Assert.IsTrue(actualMaxInCelcius <= expectedResult);
        }
    }
}