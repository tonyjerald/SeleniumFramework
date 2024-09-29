using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class BrowserActions
{
    private IWebDriver driver;

    public BrowserActions(IWebDriver webDriver)
    {
        driver = webDriver;
    }

    // Reusable module: Open browser and navigate
    public void OpenBrowser(string url)
    {
        driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();
    }

    // Reusable module: Perform login
    public void Login(string username, string password)
    {
        driver.FindElement(By.Id("username")).SendKeys(username);
        driver.FindElement(By.Id("password")).SendKeys(password);
        driver.FindElement(By.Id("loginButton")).Click();
    }

    // Reusable module: Close browser
    public void CloseBrowser()
    {
        driver.Quit();
    }
}
