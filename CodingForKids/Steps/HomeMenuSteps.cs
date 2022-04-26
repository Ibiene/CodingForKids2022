using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.Steps
{
    [Binding]
    public class HomeMenuSteps
    {
        LandingPage landingPage = new LandingPage();

        [When(@"the user is on any page of the website")]
        public void WhenTheUserIsOnAnyPageOfTheWebsite()
        {
            landingPage.IsTheUserOnAnyPageOftheWebsite().Should().BeTrue();
            landingPage.IsTheUserOnTheLandingPage().Should().BeTrue();

        }
            
        [Then(@"the Home menu is visible on the header for the user to navigate")]
        public void ThenTheHomeMenuIsVisibleOnTheHeaderForTheUserToNavigate()
        {
            landingPage.IsTheHomeMenuVisibleOnTheHeaderForTheUserToNavigate().Should().BeTrue();
        }
    }
}
