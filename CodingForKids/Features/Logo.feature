Feature: Logo
As a user on https://user-68906616-work.colibriwp.com/coding-by-k/
I want the coding for kids by kids logo and name to be visible on the left side of the website
So I can identify the website as learning management system (LMS)


@201
Scenario: Verify that logo is on the landing page

	Given the user navigate "https://user-68906616-work.colibriwp.com/coding-by-k/"
	When the user is on the landing page 
	Then the coding for kids by kids logo should be visible on the left side of the page
