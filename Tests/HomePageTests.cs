using Framework;
using Framework.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class HomePageTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.CreateDriver();
            HomePage.Open();
        }

        [Test]
        public void ChangeLanguage()
        {
            HomePage.LanguageButton();
            HomePage.ChooseLithunianLanguage();
        }

        [Test]
        public void EnterText()
        {
            HomePage.SendMessage("Sveiki, noreciau ismokti zaisti, gal galite pamokyti?");
            HomePage.EnterEmailadress("aardvark@business.com");
            HomePage.ClickSendMessage();
        }
    }
}
