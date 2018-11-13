using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SearchFunctionality
{
    public class autoherosearchfunc
    {
        [Test]
        public void SearchTest()
        {
            //initiate webdriver
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.autohero.com/de/search";
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            //TODO: if modal exists, click x to close

            //find registration by link and click
            driver.FindElement(By.XPath("//span[text()='Erstzulassung ab']")).Click();

            // select the drop down list for registration date from
            var year = driver.FindElement(By.Name("yearRange.min"));

            //create select element object 
            var selectElement = new SelectElement(year);

            //select by value
            selectElement.SelectByText("2015");

   
            // select the drop down list for sorting
            var sort = driver.FindElement(By.Name("sort"));

            //create select element object 
            var selectSort = new SelectElement(sort);

            //select by value
            selectSort.SelectByText("Höchster Preis");

            // select the drop down list for show results
            var results = driver.FindElement(By.Name("pageSize"));

            //create select element object 
            var selectResults = new SelectElement(results);

            //select by value
            selectResults.SelectByText("72");

            //close the window
            //driver.Close();

      
        }
       
    }
}