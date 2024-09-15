using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterCreator.DataObjects
{
    public class DeityEntry
    {
        public List<string>? Attribute { get; set; }
        public string? Alignment { get; set; }
        public string? Anathema { get; set; }
        public string? Category { get; set; }
        public List<string>? ClericSpell { get; set; }
        public List<string>? Deity { get; set; }
        public string? DeityMarkdown { get; set; }
        public string? DeityCategory { get; set; }
        public string? DeityCategoryMarkdown { get; set; }
        public string? DeityCategoryOrder { get; set; }
        public List<string>? DivineFont { get; set; }
        public string? DivineFontMarkdown { get; set; }
        public List<string>? Domain { get; set; }
        public string? DomainMarkdown { get; set; }
        public List<string>? DomainAlternate { get; set; }
        public string? DomainAlternateMarkdown { get; set; }
        public List<string>? DomainPrimary { get; set; }
    }
}
