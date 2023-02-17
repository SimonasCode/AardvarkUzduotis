using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
    }
}
