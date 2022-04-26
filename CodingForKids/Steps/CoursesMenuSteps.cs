using CodingForKids.PageObject;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CodingForKids.Steps
{
    [Binding]
    public class CoursesMenuSteps
    {
        LandingPage landingPage = new LandingPage();

        [Then(@"the courses menu is visible at the middle of the menu bar")]
        public void ThenTheCoursesMenuIsVisibleAtTheMiddleOfTheMenuBar()
        {
            landingPage.IsTheCoursesMenuVisibleAtTheMiddleOfTheMenuBar().Should().BeTrue();
        }

    }
}
