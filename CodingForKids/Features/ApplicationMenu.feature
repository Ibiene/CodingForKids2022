Feature: ApplicationMenu
As a user on "https://user-68906616-work.colibriwp.com/coding-by-k/"
I want the Application menu to be visible on the header 
and last on the right side of the menu bar
So I can identify the Application menu to be able to apply for the courses


@180
Scenario: verify that the application menu is visible on the right side of the header

Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
When the user is on the landing page 
Then the Application menu should be visible and last on the right side of the header
