using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAutomation.Framework.Helpers.CrawlerHelper;

namespace TestAutomation.CrawlerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]        
        public void GetElementDetails()
        {
            CrawlerHelper crawlerHelper = new CrawlerHelper();

            int waitTime = 1500; //Use this time to navigate to desired page
            CrawlerHelper.GetElementDetails("https://demoqa.com/login", waitTime);
            
        }
    }
}
