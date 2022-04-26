Feature: CoursesMenu

As a user on "https://user-68906616-work.colibriwp.com/coding-by-k/"
I want the Courses menu to be visible on the menu bar 
So I can click on it to access the courses available on the website

@workItem198
Scenario: Verify that the courses menu is visible on the menu bar
Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
When the user is on the landing page
Then the courses menu is visible at the middle of the menu bar
