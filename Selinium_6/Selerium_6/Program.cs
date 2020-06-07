using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Chrome;
using System.IO;

namespace Selerium_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a driver instance
            IWebDriver driver;

            //Initialize the instance
            driver = new FirefoxDriver();

            //launch gmail.com
            driver.Navigate().GoToUrl("http://gmail.com");

            //maximize the browser
            driver.Manage().Window.Maximize();

            //find the element by xpath and enter the email address which you want to login.
            driver.FindElement(By.XPath("//input[@aria-label='Email or phone']")).SendKeys("abdulrafaykhan97@gmail.com");

            //wait for a seconds
            Task.Delay(1000).Wait();

            //find the Next Button and click on it.
            driver.FindElement(By.XPath("//*[text()='Next']/../..")).Click();


            //wait for 2 seconds
            Task.Delay(2000).Wait();


            //find the password field and enter the password for the gmail.
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("rahila786");


            //find the Next Button and click on it.
            Task.Delay(2000).Wait();

            //get the hash code.
            int hashCodeValue = driver.GetHashCode();

            //clicking
            driver.FindElement(By.XPath("//div[@id='passwordNext']")).Click();

            driver.FindElement(By.ClassName("y2")).Click();
           // / html / body / div[7] / div[3] / div / div[2] / div[1] / div[2] / div / div / div / div / div[2] / div / div[1] / div / div / div[6] / div / div[1] / div[2] / div / table / tbody / tr[1] / td[6] / div / div / span
            //String text = driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div/div[6]/div/div[1]/div[2]/div/table/tbody/tr[1]/td[6]/div/div/div/span/span")).Text;
            //Console.WriteLine("Value is " + text);

            //driver.FindElement(By.XPath("//*[@id=':38']")).Click();

            //text = driver.FindElement(By.CssSelector("span.yP")).Text;
            //Console.WriteLine("Value is " + text);
            //driver.FindElement(By.Id(":2v")).Click();

            //IWebElement element = driver.FindElement(By.XPath("//*[@class=':zA']"));
            //element.Click();
            //print the value.
            //Console.WriteLine("Value is " + hashCodeValue);
            //element = driver.FindElement(By.XPath("//*[@id=':ob']"));
            //String text = element.Text;
            //Console.WriteLine("Value is " + text);

            //string strText = driver.FindElement(By.Id(":2r")).Text;
            //Console.WriteLine("Value is " + strText);

            // Extract the text and save it into result.txt
            //string result = driver.FindElement(By.XPath("//div[@id=':2a']")).Text;
            //File.WriteAllText("result.txt", result);
            //Console.WriteLine("Value is " + result);

            //String data = driver.FindElement(By.ClassName("aKz")).Text;
            //Console.WriteLine("Value is " + data);

            //data = driver.FindElement(By.ClassName("aKz")).Text;
            //Console.WriteLine("Value is " + data);

            //find the Next Button and click on it.
            //driver.FindElement(By.Id(":2l")).Click();
            //string strText = driver.FindElement(By.Id(":ne")).Text;
            //Console.WriteLine("Value is " + strText);

            //find the element by xpath n click.
            //driver.FindElement(By.XPath("//*[@id='gb']/div[2]/div[3]/div/div[2]/div/a")).Click();
            //driver.FindElement(By.ClassName("gb_xa gbii")).Click();
            //driver.FindElement(By.CssSelector(".gb_xa")).Click();



            //click on sign out.
            //driver.FindElement(By.XPath("//a[text()='Sign out']")).Click();

            //wait for a second
            //Task.Delay(1000).Wait();

            //close the driver instance.
            //driver.Close();

            //quit
            //driver.Quit();
        }
    }
}
