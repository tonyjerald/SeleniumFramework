using OpenQA.Selenium;

public class HybridFramework
{
    private IWebDriver driver;

    public HybridFramework(IWebDriver webDriver)
    {
        driver = webDriver;
    }

    public void ExecuteTest(string keyword, string[] args, string[] data)
    {
        switch (keyword.ToLower())
        {
            case "openbrowser":
                OpenBrowser(data[0]);
                break;
            case "login":
                Login(data[1], data[2]);
                break;
            case "closebrowser":
                CloseBrowser();
                break;
            default:
                throw new Exception("Invalid keyword");
        }
    }

    private void OpenBrowser(string url)
    {
        driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();
    }

    private void Login(string username, string password)
    {
        driver.FindElement(By.Id("username")).SendKeys(username);
        driver.FindElement(By.Id("password")).SendKeys(password);
        driver.FindElement(By.Id("loginButton")).Click();
    }

    private void CloseBrowser()
    {
        driver.Quit();
    }
}

// Example usage with test data and keywords
string[] testData = new[] { "https://example.com", "user1", "pass1" };
string[] testKeywords = new[] { "openbrowser", "login", "closebrowser" };
var hybridTest = new HybridFramework(driver);

foreach (var keyword in testKeywords)
{
    hybridTest.ExecuteTest(keyword, null, testData);
}
