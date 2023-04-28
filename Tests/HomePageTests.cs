using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
        public void pageNavigation()
        {
            HomePage.clickServicesButton();
            HomePage.clickAtlassiansSolutionButton();
            HomePage.clickCareerButton();
        }
        [Test]
        public void pageFilter()
        {
            HomePage.clickPortfolioButton();
            HomePage.clickPortfolioButton();
            HomePage.clickAndroidButton();

        }
        [Test]
        public void loadPhotos()
        {
            HomePage.clickLoadMoreButtonInHowWeSpendOurLeisure();
            HomePage.waitForElementToBeClickable();
            HomePage.clickLoadMoreButtonInHowWeSpendOurLeisure();

        }
        [TearDown]
        public virtual void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}