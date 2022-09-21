using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            driver.Url = "https://cz.careers.veeam.com/vacancies";
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void CloseBrowser()
        {
           // driver.Close();
        }
    }
}