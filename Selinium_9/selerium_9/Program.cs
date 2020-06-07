using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.Office.Interop.Excel;
using System.IO;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;
using System.Data.SqlClient;

namespace selerium_9
{
    class Program
    {
        public string connectionString = "Data Source=DESKTOP-3NEGILV\\SQLEXPRESS;Initial Catalog=FirstDatabase;Integrated Security=True";
        //SqlConnection con = new SqlConnection(connectionString);
        static void Main(string[] args)
        {
            
            IWebDriver driver;
            driver = new ChromeDriver();
            //driver.Url = "";
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
            Task.Delay(3000).Wait();


            //find the password field and enter the password for the gmail.
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("rahila786");


            //find the Next Button and click on it.
            Task.Delay(3000).Wait();

            //get the hash code.
            int hashCodeValue = driver.GetHashCode();

            //clicking
            driver.FindElement(By.XPath("//div[@id='passwordNext']")).Click();

            Task.Delay(2000).Wait();

            //clicking swiftcode label
            driver.FindElement(By.XPath("//html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div[1]/div/div/div/div[2]/div/div/div[1]/div[5]/div/div[2]/div/div/div[3]/span/a")).Click();
            Task.Delay(2000).Wait();

            string file = @"D:\New folder (2)\js internship\selerium_9\newdoc.xls";
            ExcelLibrary.SpreadSheet.Workbook workbook = new ExcelLibrary.SpreadSheet.Workbook();
            ExcelLibrary.SpreadSheet.Worksheet worksheet = new ExcelLibrary.SpreadSheet.Worksheet("First Sheet");
            //string[] lst = new string[10];
            worksheet.Cells[0, 0] = new Cell("Sender");
            worksheet.Cells[0, 1] = new Cell("mail");
            worksheet.Cells[0, 2] = new Cell("Subject");
            worksheet.Cells[0, 3] = new Cell("Requirment");


            Task.Delay(2000).Wait();

            //count unread mails
            var unread = driver.FindElement(By.XPath("//html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div[1]/div/div/div/div[2]/div/div/div[1]/div[5]/div/div[2]/div/div/div[3]/div"));
            string count = unread.Text;
            int count2= Int32.Parse(count);
            Console.WriteLine(count2);
            // int result = Int32.Parse(input);
            //List<WebElement> 
            //IWebElement unread = driver.FindElement(By.ClassName("zF"));
            //List<IWebElement> unread2 = driver.FindElements(By.ClassName("zF"));
            //string count = unread;

            for (int j = 1; j < count2+1; j++)
            {
                

                var Sender = driver.FindElement(By.XPath("//html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[1]/div/table/tbody/tr["+j+ "]/td[5]/div[2]/span/span[@class='zF']"));
                string Send = Sender.Text;
                Console.WriteLine(Send);
                Task.Delay(2000).Wait();
                worksheet.Cells[j, 0] = new Cell(Send);

                string mail = Sender.GetAttribute("email");
                Console.WriteLine(mail);
                Task.Delay(2000).Wait();
                worksheet.Cells[j, 1] = new Cell(mail);

                var Subject = driver.FindElement(By.XPath("//html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[1]/div/table/tbody/tr["+j+"]/td[6]/div/div/div/span/span"));
                string Subt = Subject.Text;
                Console.WriteLine(Subt);
                worksheet.Cells[j, 2] = new Cell(Subt);

                string req = Subt.Substring(10, 1);
                Console.WriteLine(req);
                worksheet.Cells[j, 3] = new Cell(req);

                Task.Delay(2000).Wait();
                driver.FindElement(By.XPath("//html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[1]/div/table/tbody/tr[" + j + "]")).Click();
                //driver.FindElement(By.XPath("//html/body/div[7]/div[3]/div/div[2]/div[1]/div[2]/div/div/div/div/div[2]/div/div[1]/div/div[2]/div[3]/div[1]/div/table/tbody/tr["+j+"]")).Click();
                Task.Delay(2000).Wait();
                driver.Navigate().Back();
                Task.Delay(2000).Wait();



            }
            //string file = "C:\newdoc.xls";
            //ExcelLibrary.SpreadSheet.Workbook workbook = new ExcelLibrary.SpreadSheet.Workbook();
            //ExcelLibrary.SpreadSheet.Worksheet worksheet = new ExcelLibrary.SpreadSheet.Worksheet("First Sheet");
            //worksheet.Cells[0, 1] = new Cell((short)1);
            //worksheet.Cells[2, 0] = new Cell(9999999);
            //worksheet.Cells[3, 3] = new Cell((decimal)3.45);
            //worksheet.Cells[2, 2] = new Cell("Text string");
            //worksheet.Cells[2, 4] = new Cell("Second string");
            //worksheet.Cells[4, 0] = new Cell(32764.5, "#,##0.00");
            //worksheet.Cells[5, 1] = new Cell(DateTime.Now, @"YYYY-MM-DD");
            //worksheet.Cells.ColumnWidth[0, 1] = 3000;
            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);

            // open xls file Workbook book = Workbook.Load(file); Worksheet sheet = book.Worksheets[0];

            // traverse cells foreach (Pair, Cell> cell in sheet.Cells) { dgvCells[cell.Left.Right, cell.Left.Left].Value = cell.Right.Value; }

            // traverse rows by Index for (int rowIndex = sheet.Cells.FirstRowIndex; rowIndex <= sheet.Cells.LastRowIndex; rowIndex++) { Row row = sheet.Cells.GetRow(rowIndex); for (int colIndex = row.FirstColIndex; colIndex <= row.LastColIndex; colIndex++) { Cell cell = row.GetCell(colIndex); } } 


//            driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[1]/div[4]/header/div[2]/div[3]/div/div[2]")).Click();

            //click on sign out.
//            driver.FindElement(By.XPath("//a[text()='Sign out']")).Click();

            //wait for a second
//            Task.Delay(1000).Wait();

            //close the driver instance.
//            driver.Close();

            //quit
//            driver.Quit();
        }
    }
}
