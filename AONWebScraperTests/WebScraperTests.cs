using HtmlAgilityPack;
using AONWebScraper.DataObjects;
using AONWebScraper;
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
                string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                File.WriteAllText($"{userProfilePath}\\Documents\\example.html", htmlContent);
            }
            else
            {
                Console.WriteLine("Failed to get page content.");
            }
        }
        [TestMethod()]
        public async Task GetPathfinderFeats()
        {
            
        }
    }
}
