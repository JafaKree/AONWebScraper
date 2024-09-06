using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HtmlAgilityPack;

public class WebScraper
{
    private readonly HttpClient _httpClient;

    public WebScraper()
    {
        _httpClient = new HttpClient();
    }

    public async Task<string> GetPageContentAsync(string url)
    {
        try
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(url);
            // Wait for the page to load completely
            Task.Delay(80 * 1000).Wait(); // Adjust the delay as needed
            string pageSource = driver.PageSource;
            driver.Quit();
            return pageSource;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Request error: {e.Message}");
            return null;
        }
    }

    public HtmlDocument LoadHtmlDocument(string htmlContent)
    {
        var document = new HtmlDocument();
        document.LoadHtml(htmlContent);
        return document;
    }

    public void PrintNodesText(HtmlDocument document, string xPath)
    {
        var nodes = document.DocumentNode.SelectNodes(xPath);
        if (nodes != null)
        {
            foreach (var node in nodes)
            {
                Console.WriteLine(node.InnerText);
            }
        }
        else
        {
            Console.WriteLine("No nodes found for the given XPath.");
        }
    }
    public HtmlNodeCollection GetNodes(HtmlDocument document, string xPath)
    {
        return document.DocumentNode.SelectNodes(xPath);
    }
}
