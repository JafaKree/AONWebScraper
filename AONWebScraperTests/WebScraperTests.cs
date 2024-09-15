using HtmlAgilityPack;
using AONWebScraper.DataObjects;
using AONWebScraper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Nest;

namespace Tests
{
    [TestClass()]
    public class WebScraperTests
    {
        const string index = "aon";
        const string root = "https://elasticsearch.aonprd.com/";
        const string DirectoryName = "ArchiveOfNethysData";
        [TestMethod()]
        public async Task GetFeats()
        {
            WebScraper webScraper = new WebScraper(root);
            List<ISearchResponse<object>> searchResponses = await webScraper.RetrieveTargets(new List<string>() { "feat" }, "category", index);
            Assert.IsTrue(searchResponses.Count > 0);
            foreach (ISearchResponse<object> responses in searchResponses)
            {
                webScraper.WriteData("feat", "category", responses);
            }
        }
        [TestMethod()]
        public async Task StoreFeats()
        {
            string filePath = $"{AppDomain.CurrentDomain.BaseDirectory}{DirectoryName}\\feat.json";
            string featData = File.ReadAllText(filePath);
            if(!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
            WebScraper webScraper = new WebScraper(root);
            List<FeatEntry> feats = webScraper.DeserializeData<FeatEntry>(featData);
        }
    }
}
