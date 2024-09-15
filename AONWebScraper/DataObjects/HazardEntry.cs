using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterCreator.DataObjects
{
    public class HazardEntry
    {
        public int? Ac { get; set; }
        public string? Category { get; set; }
        public string? Complexity { get; set; }
        public string? Disable { get; set; }
        public bool? ExcludeFromSearch { get; set; }
        public int? FortitudeSave { get; set; }
        public int? Hardness { get; set; }
        public string? HardnessRaw { get; set; }
        public string? HazardType { get; set; }
        public int? Hp { get; set; }
        public string? HpRaw { get; set; }
        public string? Id { get; set; }
        public List<string>? Immunity { get; set; }
        public string? ImmunityMarkdown { get; set; }
        public int? Level { get; set; }
        public string? Markdown { get; set; }
        public string? Name { get; set; }
        public string? PrimarySource { get; set; }
        public string? PrimarySourceRaw { get; set; }
        public string? PrimarySourceCategory { get; set; }
        public string? Rarity { get; set; }
        public int? RarityId { get; set; }
        public int? ReflexSave { get; set; }
        public string? ReleaseDate { get; set; }
        public string? Reset { get; set; }
        public Dictionary<string, object>? Resistance { get; set; }
        public string? SearchMarkdown { get; set; }
        public Dictionary<string, object>? SkillMod { get; set; }
        public List<string>? Source { get; set; }
        public List<string>? SourceRaw { get; set; }
        public List<string>? SourceCategory { get; set; }
        public string? SourceMarkdown { get; set; }
        public Dictionary<string, object>? Speed { get; set; }
        public string? Stealth { get; set; }
        public string? Summary { get; set; }
    }
}
