using Framework;
using Framework.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.LayerTree;
using OpenQA.Selenium.DevTools.V109.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class HomePage
    {
        private static string url = "https://ito.lt/";
        private static string servicesButton = "//*[@id='services-dropdown']";
        private static string atlassianSolutionsButton = "//div[@aria-labelledby='services-dropdown']//a[@class='dropdown-item mb-1 py-2'][1]";
        private static string careerButton = "//a[@angularticslabel='Career']";
        private static string portfolioButton = "//a[@angularticslabel='Portfolio']";
        private static string androidButton = "//*[@id='portfolio']/div/div[1]/div/div/div/div[2]/label/span[2]";
        private static string loadMoreButton = "//button[@angularticsaction='LoadMoreLeisureGalleryItems']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void clickServicesButton()
        {
            Common.ClickElement(servicesButton);
        }
        public static void clickAtlassiansSolutionButton()
        {
            Common.ClickElement(atlassianSolutionsButton);
        }
        public static void clickCareerButton()
        {
            Common.ClickElement(careerButton);
        }
        public static void clickPortfolioButton()
        {
            Common.ClickElement(portfolioButton);
        }
        public static void clickAndroidButton()
        {
            Common.ClickElement(androidButton);
        }
        public static void clickLoadMoreButtonInHowWeSpendOurLeisure()
        {
            Common.ClickElement(loadMoreButton);
        }
        public static void waitForElementToBeClickable()
        {
            Common.WaitForElementToBeClickable(loadMoreButton);
        }
    }
}
