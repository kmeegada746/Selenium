using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace FirstTest
{
    [TestClass]
    public class Setup
    {
        public IWebDriver driver;
        StringBuilder verificationErrors;
        string baseURL;
        bool acceptNextAlert = true;


        [TestMethod]
        public void SeleniumTest()
        {
            IWebDriver driver = new ChromeDriver();

            {
                driver.Navigate().GoToUrl("https://dev.cprs-pearl.com/login");
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Name("userName")).Clear();
                driver.FindElement(By.Name("userName")).SendKeys("kmeegada@cprs-inc.com");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Hello!'])[1]/following::input[2]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.Name("password")).SendKeys("Pearl@cprs");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='PearlSupport@cprs-inc.com'])[1]/following::input[1]")).Click();
                Thread.Sleep(9000);
                driver.FindElement(By.LinkText("Claims")).Click();
                driver.FindElement(By.LinkText("Open Claims")).Click();
                Thread.Sleep(55000);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[1]/div/div[3]/button")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Category'])[1]/following::div[4]")).Click();
                driver.FindElement(By.Id("react-select-3-option-1")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Type'])[1]/following::div[5]")).Click();
                driver.FindElement(By.Id("react-select-4-option-2")).Click();
                Thread.Sleep(10000);
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
                driver.FindElement(By.Id("0i")).Clear();
                driver.FindElement(By.Id("0i")).SendKeys("1500");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Claim Source'])[1]/following::a[1]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Dilution'])[23]/following::button[1]")).Click();
            }
            bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            bool IsAlertPresent()
            {
                try
                {
                    driver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }
}