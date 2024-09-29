using OpenQA.Selenium;

public class KeywordActions
{
    private IWebDriver driver;

    public KeywordActions(IWebDriver webDriver)
    {
        driver = webDriver;
    }

    public void ExecuteKeyword(string keyword, string[] args)
    {
        switch (keyword.ToLower())
        {
            case "openbrowser":
                OpenBrowser(args[0]);
                break;
            case "login":
                Login(args[0], args[1]);
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

// Example usage
var keywordTest = new KeywordActions(driver);
keywordTest.ExecuteKeyword("openbrowser", new[] { "https://example.com" });
keywordTest.ExecuteKeyword("login", new[] { "user1", "pass1" });
keywordTest.ExecuteKeyword("closebrowser", null);
