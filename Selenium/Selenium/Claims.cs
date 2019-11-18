using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
   
    public class Claims
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chromedriver");
        }

        [Test]
        public void Test()
                    {
            driver.Url = "http://www.google.co.in";
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}