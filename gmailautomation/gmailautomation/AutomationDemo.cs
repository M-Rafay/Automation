using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace gmailautomation
{
    class AutomationDemo
    {

        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.gmail.com";

            string email = "abdulrafaykhan97@gmail.com";
            var loginBox = driver.FindElement(By.Id("identifierId"));
            loginBox.SendKeys(email);

            var nextBtn = driver.FindElement(By.Id("identifierNext"));
            nextBtn.Click();
            Thread.Sleep(6000);

            string password = "rahila786";
            var pwBox = driver.FindElement(By.ClassName("whsOnd"));
            pwBox.SendKeys(password);

            Thread.Sleep(2000);


            var signinBtn = driver.FindElement(By.Id("passwordNext"));
            signinBtn.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            //driver.Close();
        }
    }
}
