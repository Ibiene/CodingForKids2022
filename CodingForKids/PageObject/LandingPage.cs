using CodingForKids.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingForKids.PageObject
{
    public class LandingPage
    {
        //Declare IWebDriver
        public IWebDriver driver;

        //Create a constructor and assign your WebHooks to the driver
        public LandingPage()
        {
            driver = WebHooks1.driver;
        }
        private By homeMenu = By.CssSelector("#menu-item-360 > a");
        private By logoItem = By.CssSelector("#navigation > div > div:nth-child(1) > div > div > div.h-column.h-column-container.d-flex.h-col-none.style-4-outer.style-local-7-h4-outer > div > div > div > a > img.h-logo__image.h-logo__image_h.logo-image.style-5-image.style-local-7-h5-image");
        private By footer = By.CssSelector("#footer");
        private By coursesMenu = By.CssSelector("#menu-primary");
        private By applicationMenu = By.CssSelector("#menu-item-365");
        private By instagram = By.CssSelector("#footer > div.h-section-grid-container.h-section-boxed-container > div.h-row-container.gutters-row-lg-2.gutters-row-md-2.gutters-row-0.gutters-row-v-lg-2.gutters-row-v-md-2.gutters-row-v-0.style-51.style-local-13-f3.position-relative > div > div.h-column.h-column-container.d-flex.h-col-lg-auto.h-col-md-auto.h-col-auto.style-235-outer.style-local-13-f19-outer > div > div > div > div > div:nth-child(1) > a");
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        public bool IsUserOnTheLandingPage()
        {
            return driver.FindElement(homeMenu).Displayed;
        }
        public bool IsTheLogoVisibleOnTheLeftSideOfThePage()
        {
            return driver.FindElement(logoItem).Displayed;
        }
        public bool IsTheFooterVisibleAtTheBottomOfTheLandingPage()
        {
            return driver.FindElement(footer).Displayed;
        } 

        public bool IsTheCoursesMenuVisibleAtTheMiddleOfTheMenuBar()
        {
            return driver.FindElement(coursesMenu).Displayed;
        }
        public bool IsTheApplicationMenuVisibleAndLastOnTheRightSideOfTheHeader()
        {
            return driver.FindElement(applicationMenu).Displayed;
        }
        public bool IsTheHomeMenuVisibleOnTheHeaderForTheUserToNavigate()
        {
            return driver.FindElement(homeMenu).Displayed;
        }
        public bool IsTheUserOnAnyPageOftheWebsite()
        {
            return driver.FindElement(homeMenu).Displayed;
            
        }
        public bool IsTheUserOnTheLandingPage()
        {
           //This is one way of asserting methods
            return driver.Url == "https://user-68906616-work.colibriwp.com/coding-by-k/";

        }
        public bool IsTheUserOnTheLandingPage2()
        {
            //This is one way of asserting 
            return driver.Title.Contains("Just another WordPress site");

        }

        public bool IsTheUserOnTheLandingPage3()
        {
            return driver.FindElement(instagram).Displayed;
            
        }
        public void ClickInstagram()
        {
            driver.FindElement(instagram).Click();
        }
    }

}
