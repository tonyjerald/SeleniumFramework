using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

// example of gherkin
//Feature: Login
//  Scenario: Successful login with valid credentials
//    Given the user is on the login page
//    When the user enters valid credentials
//    Then the user should see the dashboard
//

[Binding]
public class LoginSteps
{
    private IWebDriver driver;

    [Given(@"the user is on the login page")]
    public void GivenTheUserIsOnTheLoginPage()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://example.com");
    }

    [When(@"the user enters valid credentials")]
    public void WhenTheUserEntersValidCredentials()
    {
        driver.FindElement(By.Id("username")).SendKeys("validUser");
        driver.FindElement(By.Id("password")).SendKeys("validPass");
        driver.FindElement(By.Id("loginButton")).Click();
    }

    [Then(@"the user should see the dashboard")]
    public void ThenTheUserShouldSeeTheDashboard()
    {
        Assert.IsTrue(driver.FindElement(By.Id("welcomeMessage")).Displayed);
        driver.Quit();
    }
}
