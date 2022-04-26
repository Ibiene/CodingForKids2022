using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.Steps
{
    [Binding]
    public class LogoSteps
    {
        //Declare your PageObject and instatiate it 
        LandingPage landingPage = new LandingPage();

        [Given(@"the user navigate ""(.*)""")]
        public void GivenTheUserNavigate(string url)
        {
            landingPage.NavigateToWebsite(url); 
        }
        
        [When(@"the user is on the landing page")]
        public void WhenTheUserIsOnTheLandingPage()
        {
            landingPage.IsUserOnTheLandingPage().Should().BeTrue();  
        }
        [Then(@"the coding for kids by kids logo should be visible on the left side of the page")]
        public void ThenTheCodingForKidsByKidsLogoShouldBeVisibleOnTheLeftSideOfThePage()
        {
            landingPage.IsTheLogoVisibleOnTheLeftSideOfThePage().Should().BeTrue();
        }
    }
}
