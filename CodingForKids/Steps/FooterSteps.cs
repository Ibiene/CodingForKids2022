using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.Steps
{
    [Binding]
    public class FooterSteps
    {
        // Declare your page object and instantiate it 
        LandingPage landingPage = new LandingPage();

        [Then(@"the footer should be visible to the bottom of the page")]
        public void ThenTheFooterShouldBeVisibleToTheBottomOfThePage()
        {
            landingPage.IsTheFooterVisibleAtTheBottomOfTheLandingPage().Should().BeTrue();   
        }
    }
}
