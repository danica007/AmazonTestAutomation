# Amazon Test Automation Testing using Selenium WebDriver C#

This is a small test automation task to automate search of a laptop and assert it's price.

## Test Flow
 - Navigate to https://www.amazon.com/  
 - Type in “laptop” in the search text box 
 - Click on “Search” button 
 - Click on the first result  
 - Upon page loaded, assert that the laptop price is more than $100.  

## Project
 - Create a unit test C# project using Visual Studio
 - Using NuGet, find and install Selenium WebDriver
 - Download ChromeDriver and placed in C:\Driver\

## Implementation Decision:
  - Page Object Model - each page of the application within the scope is represented by one class.
  - Use different element locators -- id, name, cssSelector
  - Single Responsibility Principle - creates an application class that handles user behavior. 
  - Test Case - add a test case that asserts the price as required.
  
## Run the test
Simply hit F5, to run the test.
