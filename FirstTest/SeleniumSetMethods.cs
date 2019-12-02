using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace FirstTest
{
    class SeleniumSetMethods
    {
        //Enter text
        public static void EnterText(IWebDriver driver,string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(elementtype)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Id(elementtype)).SendKeys(value);
        }

        //Click into a button, Checkbox, option etc
        public static void Click(IWebDriver driver, string element,string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(elementtype)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Id(elementtype)).Click();
        }

        //Selecting a Dropdown Control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(elementtype))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(elementtype))).SelectByText(value);
        }

    }
}
