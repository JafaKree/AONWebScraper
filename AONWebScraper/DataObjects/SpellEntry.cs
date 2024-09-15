using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterCreator.DataObjects
{
    public class SpellEntry
    {
        public string? Actions { get; set; }
        public int? ActionsNumber { get; set; }
        public List<string>? Bloodline { get; set; }
        public string? BloodlineMarkdown { get; set; }
        public string? Category { get; set; }
        public List<string>? Component { get; set; }
        public string? DomainMarkdown { get; set; }
        public bool? ExcludeFromSearch { get; set; }
        public List<string>? HeightenGroup { get; set; }
        public List<int>? HeightenLevel { get; set; }
        public string? Id { get; set; }
        public int? Level { get; set; }
        public string? Markdown { get; set; }
        public string? Name { get; set; }
        public List<string>? PatronTheme { get; set; }
        public string? PatronThemeMarkdown { get; set; }
        public string? Pfs { get; set; }
        public string? PrimarySource { get; set; }
        public string? PrimarySourceRaw { get; set; }
        public string? PrimarySourceCategory { get; set; }
        public int? Range { get; set; }
        public string? RangeRaw { get; set; }
        public string? Rarity { get; set; }
        public int? RarityId { get; set; }
        public string? ReleaseDate { get; set; }
        public Dictionary<string, object>? Resistance { get; set; }
        public string? SavingThrow { get; set; }
        public string? SavingThrowMarkdown { get; set; }
        public string? School { get; set; }
        public string? SearchMarkdown { get; set; }
        public Dictionary<string, object>? SkillMod { get; set; }
        public List<string>? Source { get; set; }
        public List<string>? SourceRaw { get; set; }
    }
}
