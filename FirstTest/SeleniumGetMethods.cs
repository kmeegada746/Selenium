using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("ValueType");
            if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("ValueType");
            else return String.Empty;
        }
        //To select innterText
        public static string GetTextDDL(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
