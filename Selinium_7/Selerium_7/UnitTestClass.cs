using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;



namespace Selerium_7
{
    class UnitTestClass
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
            //driver.Url = "http://www.google.co.in";
            driver.Url = "https://www.guru99.com/selenium-csharp-tutorial.html#2";

            String title = driver.Title;
            Console.WriteLine(title);

            String pageSource = driver.PageSource;
            Console.WriteLine(pageSource);
            //driver.Navigate().Back();
            //driver.Navigate().Forward()
            //driver.Navigate().Refresh()


        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            //driver.Quit();
            

        }

    }
}
