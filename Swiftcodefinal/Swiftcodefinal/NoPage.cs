using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Swiftcodefinal
{
    class NoPage
    {
         ArrayList Links = new ArrayList();


        public ArrayList FindNoPages1(IWebDriver driv)
        {

            
            try
            {

                IWebElement pg = driv.FindElement(By.XPath("//*[@id='maindiv']/div[3]/div/div/table/tbody/tr/td[2]/p"));

                IList<IWebElement> PageNo;



                PageNo = pg.FindElements(By.TagName("a"));



                for (int i = 0; i < PageNo.Count; i++)
                {
                    Links.Add(PageNo.ElementAt(i).GetAttribute("href"));


                }

                Console.Write(Links.Count);

                Console.ReadKey();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            return Links;
        }
    }
}

