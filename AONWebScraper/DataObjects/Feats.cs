using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AONWebScraper.DataObjects
{
    public class FeatsTable
    {
        required public List<FeatRow> Feats { get; set; }
        public class FeatRow
        {
            required public string Name { get; set; }
            required public string PFSRDLink { get; set; }
            required public string Source { get; set; }
            required public string Rarity { get; set; }
            required public string Trait { get; set; }
            required public string Level { get; set; }
            public string? Prerequisites { get; set; }
            required public string Summary { get; set; }
            public string? Spoilers { get; set; }
        }
    }
}
