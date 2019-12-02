using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using FirstTest;

namespace SeleniumTest
{
    //[TestClass]
    class Program
    {
        //create the reference for our browser
        IWebDriver driver = new ChromeDriver();
        static void Main(String[] args)
        {
        }
        [SetUp]

        public void Intialize()
        {
            //Navigate to Pearls page
            driver.Navigate().GoToUrl("https://dev.cprs-pearl.com/login");
            //driver.Navigate().GoToUrl("https://cprs-pearl.com/login");
            //driver.Navigate().GoToUrl("https://preprod.cprs-pearl.com/login");
            //driver.Navigate().GoToUrl("https://qa.cprs-pearl.com/login");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("userName")).Clear();
            //driver.FindElement(By.Name("userName")).SendKeys("kmeegada@cprs-inc.com");
            driver.FindElement(By.Name("userName")).SendKeys("S_CostcoAU_Supervisor@cprsonline.com");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Hello!'])[1]/following::input[2]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            //driver.FindElement(By.Name("password")).SendKeys("Pearl@costco");
            driver.FindElement(By.Name("password")).SendKeys("Wz_]KTq>Q:PG9wGp");

        }

        [Test]
        public void AddNewClaimTest()
        {

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='PearlSupport@cprs-inc.com'])[1]/following::input[1]")).Click();
            Thread.Sleep(10000);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15000);
            //Thread.Sleep(95000);
            for (int i = 1; i < 3; i++)
            {
                SeleniumSetMethods.Click(driver,"Claims","Id");
                //driver.FindElement(By.LinkText("Claims")).Click();
                driver.FindElement(By.LinkText("Open Claims")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(95000);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/div/div[3]/button")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
                //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Category'])[1]/following::div[4]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Allowance'])[1]/following::*[name()='svg'][1]")).Click();
                driver.FindElement(By.Id("react-select-3-option-2")).Click();
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
                //driver.FindElement(By.Id("react-select-3-option-1")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Type'])[1]/following::div[5]")).Click();
                driver.FindElement(By.Id("react-select-4-option-2")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
                //Thread.Sleep(10000);
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[1]/following::div[4]")).Click();
                driver.FindElement(By.Id("react-select-5-option-2")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='*'])[2]/following::div[4]")).Click();
                driver.FindElement(By.Id("react-select-6-option-2")).Click();
                driver.FindElement(By.Name("Description")).Click();
                driver.FindElement(By.Name("Description")).Clear();
                driver.FindElement(By.Name("Description")).SendKeys("Testing");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Audit Year'])[1]/following::div[4]")).Click();
                driver.FindElement(By.Id("react-select-7-option-1")).Click();
                driver.FindElement(By.Id("0s")).Click();
                driver.FindElement(By.Id("react-select-8-option-0")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='AUS | US | All US Locations'])[1]/following::div[11]")).Click();
                driver.FindElement(By.Id("react-select-9-option-346")).Click();
                driver.FindElement(By.Id("0i")).Click();
                //driver.FindElement(By.Id("0i")).Clear();
                Random number = new Random();
                int amount = number.Next(1500, 2000);
                driver.FindElement(By.Id("0i")).SendKeys("" + amount);
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3000);
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Claim Source'])[1]/following::a[1]")).Click();
                Thread.Sleep(95000);
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(950000);
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(95000);
                //UAT
                //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Alaska/Hawaii/Puerto Rico'])[3]/following::button[1]")).Click();
                // QA 
                //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Alaska/Hawaii/Puerto Rico'])[7]/following::button[1]")).Click();
                //DEV 
                //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Dilution'])[23]/following::button[1]")).Click();
            }
        }
        [Test]
        public void EditClaimTest()
        {

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Hello!'])[1]/following::input[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Name("password")).SendKeys("Pearl@costco");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='PearlSupport@cprs-inc.com'])[1]/following::input[1]")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.LinkText("Claims")).Click();
            driver.FindElement(By.LinkText("Open Claims")).Click();
            Thread.Sleep(90000);
            driver.FindElement(By.XPath("//img[contains(@src,'data:image/svg+xml;base64,PHN2ZyBpZD0iTGF5ZXJfMSIgZGF0YS1uYW1lPSJMYXllciAxIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAzMCAzMCI+PGRlZnM+PHN0eWxlPi5jbHMtMXtmaWxsOiNmZmY7fS5jbHMtMntmaWxsOiNiMWIxYjE7fS5jbHMtM3tmaWxsOiNlNmU2ZTY7fTwvc3R5bGU+PC9kZWZzPjx0aXRsZT5jYXJkLXZpZXctdW5zZWxlY3RlZEFydGJvYXJkIDE8L3RpdGxlPjxnIGlkPSJFbGxpcHNlXzI4IiBkYXRhLW5hbWU9IkVsbGlwc2UgMjgiPjxjaXJjbGUgY2xhc3M9ImNscy0xIiBjeD0iMTUiIGN5PSIxNSIgcj0iMTUiLz48cGF0aCBjbGFzcz0iY2xzLTIiIGQ9Ik0xNSwzMEExNSwxNSwwLDEsMSwzMCwxNSwxNSwxNSwwLDAsMSwxNSwzMFpNMTUsMUExNCwxNCwwLDEsMCwyOSwxNSwxNCwxNCwwLDAsMCwxNSwxWiIvPjwvZz48ZyBpZD0iUGF0aF81MjUiIGRhdGEtbmFtZT0iUGF0aCA1MjUiPjxwb2x5Z29uIGNsYXNzPSJjbHMtMyIgcG9pbnRzPSIxMi4xOSAxOC45NiA5LjIgMTQuNDcgMTAuMDMgMTMuOTEgMTIuNDIgMTcuNSAyMC4wNyAxMS4zOCAyMC43IDEyLjE2IDEyLjE5IDE4Ljk2Ii8+PC9nPjwvc3ZnPg==')]")).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@class='btn btn-block formbutton editbtn']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Freight Allowance'])[1]/following::div[7]")).Click();
            driver.FindElement(By.Id("react-select-3-option-2")).Click();
            Thread.Sleep(10000);

            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Alaska/Hawaii/Puerto Rico'])[21]/following::div[7]")).Click();
            //driver.FindElement(By.Id("react-select-4-option-3")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Alaska/Hawaii/Puerto Rico'])[18]/following::div[7]")).Click();
            //driver.FindElement(By.Id("react-select-4-option-19")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vendor Number | Name'])[1]/following::div[9]")).Click();
            driver.FindElement(By.Id("react-select-5-option-3")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Department'])[1]/following::div[8]")).Click();
            driver.FindElement(By.Id("react-select-6-option-1")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Department'])[1]/following::div[16]")).Click();
            driver.FindElement(By.LinkText("+ Add")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='KrishnaM_PTG-GMM'])[1]/following::div[12]")).Click();
            driver.FindElement(By.Id("react-select-17-option-2")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='AWC | WC | All Western Canada Regions'])[1]/following::div[10]")).Click();
            driver.FindElement(By.Id("react-select-18-option-347")).Click();
            driver.FindElement(By.Id("1i")).Click();
            driver.FindElement(By.Id("1i")).Clear();
            driver.FindElement(By.Id("1i")).SendKeys("2500");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vendor Audit'])[1]/following::div[7]")).Click();
            driver.FindElement(By.Id("react-select-7-option-1")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='EVN'])[1]/following::div[7]")).Click();
            driver.FindElement(By.Id("react-select-8-option-1")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='S_CostcoAU_Supervisor'])[1]/following::div[8]")).Click();
            driver.FindElement(By.Id("react-select-9-option-3")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Standard'])[1]/following::div[7]")).Click();
            driver.FindElement(By.Id("react-select-10-option-1")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='ZAR0 (A)'])[1]/following::div[7]")).Click();
            driver.FindElement(By.Id("react-select-11-option-1")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)=concat('Type ', '\"', 'Delete', '\"', ' to Delete')])[1]/following::button[1]")).Click();

        }


        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}


