Feature: SignIn functionality.
	

@firstTests
  Scenario: As I user I want to navigate to sign in.
	Given Load the page.
	And Click on SignIn button.
	And Enter e-mail address.
	When I click Create Account.
	Then I can see Create an Account File.