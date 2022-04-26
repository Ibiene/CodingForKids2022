using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.Steps
{
    [Binding]
    public class InstagramSteps 
    {
      
        LandingPage landingPage = new LandingPage();
    
        [When(@"the user clicks on the Instagram icon on the footer")]
        public void WhenTheUserClicksOnTheInstagramIconOnTheFooter()
        {
            landingPage.ClickInstagram();
        }
        
        [Then(@"it takes the user to the Instagram page")]
        public void ThenItTakesTheUserToTheInstagramPage()
        {
            landingPage.IsTheUserOnTheInstagramPage().Should().BeTrue();
        }
    }
}
