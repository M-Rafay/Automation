using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.google.com");

            //Maximize the window
            driver.Manage().Window.Maximize();

            //Find the Search text box using xpath
            IWebElement element = driver.FindElement(By.XPath("//*[@title='Search']"));

            //Enter some text in search text box
            element.SendKeys("learn-automation");

            //Close the browser
            //driver.Close();
        }
    }
}
