using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class ModularTests
{
    private IWebDriver driver;
    private BrowserActions browserActions;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        browserActions = new BrowserActions(driver);
    }

    [Test]
    public void TestLoginFunctionality()
    {
        // Use the module to open browser
        browserActions.OpenBrowser("https://example.com");

        // Use the login module
        browserActions.Login("testuser", "testpassword");

        // Validate the login was successful
        Assert.IsTrue(driver.FindElement(By.Id("welcomeMessage")).Displayed);

        // Close the browser
        browserActions.CloseBrowser();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}
