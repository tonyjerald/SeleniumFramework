using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

[TestFixture]
public class DataDrivenTest
{
    private IWebDriver driver;
    private BrowserActions browserActions;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        browserActions = new BrowserActions(driver);
    }

    [Test, TestCaseSource("LoginData")]
    public void TestLoginWithData(string username, string password)
    {
        browserActions.OpenBrowser("https://example.com");
        browserActions.Login(username, password);
        Assert.IsTrue(driver.FindElement(By.Id("welcomeMessage")).Displayed);
        browserActions.CloseBrowser();
    }

    public static IEnumerable<TestCaseData> LoginData()
    {
        yield return new TestCaseData("user1", "pass1");
        yield return new TestCaseData("user2", "pass2");
        yield return new TestCaseData("user3", "pass3");
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
