using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using Microsoft.Extensions.Logging;
using Nest;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
namespace AONWebScraper
{
    public class WebScraper
    {
        private readonly CustomLogger _logger;
        private ElasticClient client;
        private const string DirectoryName = "ArchiveOfNethysData";
        public List<string> targets = new List<string> {
                "action",
                "ancestry",
                "archetype",
                "armor",
                "article",
                "background",
                "class",
                "creature",
                "creature-family",
                "deity",
                "equipment",
                "feat",
                "hazard",
                "rules",
                "skill",
                "shield",
                "spell",
                "source",
                "trait",
                "weapon",
                "weapon-group",
            };
        public WebScraper(string root)
        {
            CustomLoggerConfiguration config = new CustomLoggerConfiguration();
            CustomLogger logger = new CustomLogger("Logger", config);
            _logger = logger;
            client = new ElasticClient(new ConnectionSettings(new Uri(root)));
        }
        public async System.Threading.Tasks.Task<List<ISearchResponse<object>>> RetrieveTargets(List<string> targets, string category, string index)
        {
            if (targets == null)
            {
                throw new ArgumentNullException(nameof(targets));
            }
            List<ISearchResponse<object>> searchResponses = new List<ISearchResponse<object>>();
            foreach (var target in targets)
            {
                try
                {
                    _logger.LogInformation($"Retrieving data for {target}");
                    ISearchResponse<object> searchResponse = await client.SearchAsync<object>(s => s
                        .Index(index)
                        .From(0)
                        .Size(10000)
                        .Query(q => q
                            .Match(m => m
                                .Field(category)
                                .Query(target)
                            )
                        )
                    );
                    _logger.LogInformation($"Retrieved {searchResponse.Documents.Count} documents for {target}");
                    searchResponses.Add(searchResponse);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error processing target {target}: {ex.Message}");
                }
            }
            return searchResponses;
        }
        public void WriteData(string target, string category, ISearchResponse<object> searchResponse)
        {
            string rawDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DirectoryName);
            if (!Directory.Exists(rawDirectory))
            {
                _logger.LogInformation($"Creating directory {rawDirectory}");
                Directory.CreateDirectory(rawDirectory);
            }
            string filePath = Path.Combine(rawDirectory, $"{target}.json");
            if (File.Exists(filePath)) {
                File.Delete(filePath);
            }
            _logger.LogInformation($"Writing data to {filePath}");
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            File.WriteAllText(filePath, JsonSerializer.Serialize(searchResponse.Documents, options));
        }
        public List<T> DeserializeData<T>(string data) where T : class
        {
            if(data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            List<T> objData = JsonSerializer.Deserialize<List<T>>(data);
            if (objData == null)
            {
                throw new ArgumentNullException(nameof(objData));
            }
            return objData;
        }
    }
}