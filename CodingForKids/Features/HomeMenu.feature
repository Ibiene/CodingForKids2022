Feature: HomeMenu
As a user on "https://user-68906616-work.colibriwp.com/coding-by-k/"
I want to access the home menu on the header 
So, I can access the landing page from any page of the website

@117
Scenario: Verify that the homeMenu is visible on the header
Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
When the user is on any page of the website 
Then the Home menu is visible on the header for the user to navigate 

