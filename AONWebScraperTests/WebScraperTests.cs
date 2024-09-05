using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class WebScraperTests
    {

        [TestMethod()]
        public async Task GetPageContentAsyncTestAsync()
        {
            WebScraper scraper = new WebScraper();
            string url = "https://2e.aonprd.com/";
            string htmlContent = await scraper.GetPageContentAsync(url);

            if (htmlContent != null)
            {
                HtmlDocument document = scraper.LoadHtmlDocument(htmlContent);
                Assert.IsNotNull(document);
                string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                document.Save($"{userProfilePath}\\Desktop\\example.html");
            }
            else
            {
                Console.WriteLine("Failed to get page content.");
            }
        }
    }
}

namespace AONWebScraperTests
{
    internal class WebScraperTests
    {
    }
}
