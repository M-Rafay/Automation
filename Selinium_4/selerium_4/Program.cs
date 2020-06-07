using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace selerium_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";
        }
    }
}
