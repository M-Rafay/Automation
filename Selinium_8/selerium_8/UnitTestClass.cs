using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selerium_8
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
            driver.Url = "https://www.guru99.com/selenium-csharp-tutorial.html#2";

            string title = driver.Title;
            Console.WriteLine(title);
            IWebElement element = driver.FindElement(By.XPath("//*[@id='menu-6632-particle']/nav/ul/li[9]/a/span/span"));// element.Click();
                                                            

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
