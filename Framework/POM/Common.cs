using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Framework.POM
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        public static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        public static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static void EnterText(string locator, string text)
        {
            IWebElement element = GetElement(locator);
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }
        internal static void ClickEnterButton(string locator)
        {
            IWebElement element = GetElement(locator);
            element.SendKeys(Keys.Enter);
        }

        internal static void WaitForElementToBeClickable(string cancelButton)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(15));
        }
        public static IWebElement GetElements(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

    }
}
