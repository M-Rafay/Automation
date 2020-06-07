using GemBox.Spreadsheet;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;


namespace Swiftcodefinal
{
    class Program
    {
        // private static object driv;

        static void Main()
        {
            try
            {
                // List  FindList1= new List();
                IWebDriver driver = new ChromeDriver(@"C:\Users\92331\source\repos\Swiftcodefinal\Swiftcodefinal\BrowserDriver");
                driver.Url = "https://www.bankswiftcode.org/";
                driver.Manage().Window.Maximize();
                String[] A = new String[70];
                ArrayList Countries = new ArrayList();
                Thread.Sleep(2000);
                IList<IWebElement> MyList;
                IWebElement header = driver.FindElement(By.XPath("//*[@id='maindiv']/div[3]/table/tbody/tr/td[2]/div[3]/div[2]/table"));
                MyList = header.FindElements(By.XPath(".//*"));

                A = MyList.ElementAt(0).Text.Split('.');
                //Excel.Application excelApp = new Excel.ApplicationClass();


                //Excel.Worksheet newWorksheet;

                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                SpreadsheetInfo.FreeLimitReached += (sender, e) => e.FreeLimitReachedAction = FreeLimitReachedAction.Stop;

                ////here do write further coding
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Countrynames");
                A = MyList.ElementAt(0).Text.Split('.');
                Regex regex = new Regex(@"\w[a-zA-Z]+\w");
                int row1 = 0, col1 = 0;
                MatchCollection match;
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                for (int i = 0; i < A.Length; i++)
                {
                    match = regex.Matches(A[i]);
                    string s = null;

                    foreach (Match m in match)
                    {
                        var dataTable = new DataTable();
                        dataTable.Columns.Add("CountryNames", typeof(string));
                        s = s + ' ' + m;

                        Countries.Add(s);

                        for (int k = 0; k < Countries.Count; k++)
                        {
                            worksheet.Cells[row1, col1].Value = Convert.ToString(Countries[k]);
                            //  dataTable.Rows.Add(Countries[k]);

                        }
                        row1++;
                        //worksheet.InsertDataTable(dataTable, new InsertDataTableOptions()
                        //{
                        //    ColumnHeaders = true,
                        //    StartRow = 0
                        //});


                    }
                }




                int size = Countries.Count;
                int l1 = 1;
            abc:
                try
                {
                    for (int y = l1; y < size; y++)
                    {

                        l1 = y;




                        //SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                        //SpreadsheetInfo.FreeLimitReached += (sender, e) => e.FreeLimitReachedAction = FreeLimitReachedAction.Stop;





                        driver.Navigate().GoToUrl("https://www.bankswiftcode.org/" + Countries.ToArray().ElementAt(y).ToString().ToLower() + "/");

                        //Instantiating a "Products" DataTable object


                        IWebElement AllEntries = driver.FindElement(By.Id("t2"));
                        //To calculate no of rows In table.
                        IList<IWebElement> rows = AllEntries.FindElements(By.TagName("tr"));
                        //int rows_count = rows.Count;
                        //ye static bnywya hai list

                        // int i = 1; 
                        string v = (string)Countries[y];
                        var worksheet2 = workbook.Worksheets.Add(v);
                        //var worksheet2 = workbook.Worksheets.Add(i+1);
                        // worksheet.Name = v;
                        //  i++;
                        //  Excel.Range cells = newWorksheet.Cells;

                        //Input a string value to a cell of the sheet.
                        // cells.set_Item(y, y + y.ToString());
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Institution", typeof(string));
                        dt.Columns.Add("Institution2", typeof(string));
                        dt.Columns.Add("Institution3", typeof(string));
                        dt.Columns.Add("Institution4", typeof(string));
                        dt.Columns.Add("Institution5", typeof(string));




                        // string v = (string)Countries[y];
                        // var worksheet = workbook.Worksheets.Add("");
                        //  worksheet.Name = v + i.ToString(); ;
                        // Worksheet sheetCurrent = xlApp.Worksheets.Add();
                        // string sheetName = workbook.Worksheets[d].Name;


                        int sheetrow = 0, sheetcol = 0;

                        foreach (IWebElement row in rows)
                        {
                            IList<IWebElement> cols = row.FindElements(By.TagName("td"));
                            //int columns_count =cols.Count;

                            foreach (IWebElement col in cols)
                            {
                                String celtext = col.Text;

                                if (celtext == null)
                                {
                                    celtext = "\t";
                                }

                                worksheet2.Cells[sheetrow, sheetcol].Value = Convert.ToString(celtext);
                                //  worksheet1.Cells[sheetrow, sheetcol].Value = Convert.ToString(celtext);

                                sheetcol++;
                            }

                            sheetcol = 1;
                            sheetrow++;

                        }

                        //Activate the first worksheet by default.
                        //((Excel.Worksheet)excelApp.ActiveWorkbook.Sheets[1]).Activate();

                        ////Save As the excel file.
                        //excelApp.ActiveWorkbook.SaveAs(@"C:\office\out_My_Book2.xls");

                        ////Quit the Application.
                        //excelApp.Quit();


                        workbook.Save(@"C:\office\swift688.xls");

                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    l1++;
                    goto abc;
                }
            }





            catch (Exception e)
            {
                Console.WriteLine(e);
                // throw new Exception ("test");
                // continue;

            }

        }

    }
}









