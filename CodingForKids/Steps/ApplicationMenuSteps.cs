using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.Steps
{
    [Binding]
    public class ApplicationMenuSteps
    {
        LandingPage landingPage = new LandingPage();

        [Then(@"the Application menu should be visible and last on the right side of the header")]
        public void ThenTheApplicationMenuShouldBeVisibleAndLastOnTheRightSideOfTheHeader()
        {
            landingPage.IsTheApplicationMenuVisibleAndLastOnTheRightSideOfTheHeader().Should().BeTrue();
        }
    }
}
