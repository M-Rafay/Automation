using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selerium_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a driver instance
            IWebDriver driver;

            //create IE driver instance
            driver = new ChromeDriver();

            //Open learn-automation.com
            driver.Navigate().GoToUrl("http://learn-automation.com/");

            //find Element with xpath and click on it
            driver.FindElement(By.XPath("//*[text()='Katalon']/..")).Click();
            //artOfTestingLogo.click();
            //click on back button using navigate
            driver.Navigate().Back();

            //click on forward button using navigate
            driver.Navigate().Forward();

            //click on refresh
            driver.Navigate().Refresh();

            //close the driver instance
            driver.Close();
        }
    }
}
