using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selerium_3
{
    class NunitExample
    {
        IWebDriver driver;
        public void Initialize()
        {
            //create a firefox driver instance
            driver = new ChromeDriver();

        }
        public void LaunchApp()
        {
            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Launch a website
            driver.Url = "http://learn-automation.com/";
        }
        public void ShutDown()
        {
            driver.Close();
        }

    }
}
