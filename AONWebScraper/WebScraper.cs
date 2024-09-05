using System;
using System.Net.Http;
using System.Threading.Tasks;
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
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
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
