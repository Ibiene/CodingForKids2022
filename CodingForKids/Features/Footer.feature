Feature: Footer
As a user on "https://user-68906616-work.colibriwp.com/coding-by-k/"
I want the footer to be rectangle with blue background 
So I can identify the website and navigate the footer


@102
Scenario: Verify that the footer is visible
Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
When the user is on the landing page 
Then the footer should be visible to the bottom of the page

