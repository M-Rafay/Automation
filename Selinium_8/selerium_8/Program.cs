using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace selerium_8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IWebDriver driver;
        
            driver = new ChromeDriver();
        

        
            driver.Url = "https://www.guru99.com/selenium-csharp-tutorial.html#2";
            //String parentWindowHandle = driver.CurrentWindowHandle;
            //Console.WriteLine("Parent window's handle -> " + parentWindowHandle);
            // Get the current window handle so you can switch back later.
            string currentHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + currentHandle);


            string title = driver.Title;
            Console.WriteLine(title);
            //driver.SwitchTo().Window(parentWindowHandle);
            //Wait for web element to become visible
            System.Threading.Thread.Sleep(15000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //IWebElement element = driver.FindElement(By.XPath("//*[@id='menu-6632-particle']/nav/ul/li[9]/a/span/span"));
            driver.SwitchTo().Window(currentHandle);

            driver.FindElement(By.XPath("/html/body/div[2]/section[3]/div/div[1]/main/div[1]/div/div/div/div/div/div[2]/div[2]/div/ul/li[1]/a")).Click();
            //driver.FindElement(By.Id("menu-6632-particle")).Click();

            //WebDriverWait wait = new WebDriverWait(driver, 120);
            //wait.Until(ExpectedConditions.visibilityOfElementLocated(By.XPath("<Element path>")));




            //element.Click();

            driver.Navigate().Back();
            //driver.Navigate().Forward();
            driver.Navigate().Refresh();
            //driver.Navigate().Back();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.SwitchTo().Window(currentHandle);
            //IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/section[3]/div/div[1]/main/div[1]/div/div/div/div/div/div[2]/p[8]/a"));
            //element.Click();
            //driver.SwitchTo().Window(currentHandle);

            IWebElement element = driver.FindElement(By.XPath("/html/body/div[2]/section[3]/div/div[1]/main/div[1]/div/div/div/div/div/div[1]/h1"));
            string text = element.Text;
            Console.WriteLine(text);

            string tagName = element.TagName;
            Console.WriteLine(tagName);

            //element = driver.FindElement(By.XPath("/html/body/div[2]/section[2]/div/div/div[2]/div/nav/ul/li[2]/ul/li/div/div[1]/ul/li[2]/a"));
            //SelectElement select = new SelectElement(element);
            //select.SelectByIndex("4");

            driver.Close();
        

    }
    }
}
