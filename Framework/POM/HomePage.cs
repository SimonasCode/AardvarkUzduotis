using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Framework.POM
{
    public class HomePage
    {
        private static string url = "https://demo.betgames.tv/";
        private static string language = "//*[@id='language']";
        private static string lithuanian = "//*[@id = 'language']//div[@class = 'dropdown-menu multi-column']//div[@class = 'col-md-4 col-xs-4'][2]//ul[@class = 'dropdown-menu']/li[10]/a";
        private static string EnterMessage = "//*[@id='message']";
        private static string emailEnter = "//*[@id='email']";
        private static string clicksendButton = "//form[@id = 'contact']//button[@class = 'send btn btn-primary pull-left']";
        public static void Open()
        {
            Driver.OpenPage(url);
            //Common.ClickElement("");
            //Driver.GetDriver().FindElement(By.XPath("")).Click();
        }

        public static void LanguageButton()
        {
            Common.ClickElement(language);
        }

        public static void ChooseLithunianLanguage()
        {
            Common.ClickElement(lithuanian);
        }

        public static void SendMessage(string text)
        {
            Common.EnterText(EnterMessage, text);
        }

        public static void EnterEmailadress(string email)
        {
            Common.EnterText(emailEnter, email);
        }

        public static void ClickSendMessage()
        {
            Common.ClickElement(clicksendButton);
        }
    }
}
