using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PathfinderCharacterCreator.DataObjects
{
    public class ActionEntry
    {
        public string? Actions { get; set; }
        public int ActionsNumber { get; set; }
        public string? Category { get; set; }
        public bool ExcludeFromSearch { get; set; }
        public string? Id { get; set; }
        public string? Markdown { get; set; }
        public string? Name { get; set; }
        public string? PrimarySource { get; set; }
        public string? PrimarySourceRaw { get; set; }
        public string? PrimarySourceCategory { get; set; }
        public string? Rarity { get; set; }
        public int RarityId { get; set; }
        public string? ReleaseDate { get; set; }
        public Dictionary<string, object>? Resistance { get; set; }
        public string? SearchMarkdown { get; set; }
        public Dictionary<string, object>? SkillMod { get; set; }
        public List<string>? Source { get; set; }
        public List<string>? SourceRaw { get; set; }
        public List<string>? SourceCategory { get; set; }
        public string? SourceMarkdown { get; set; }
        public Dictionary<string, object>? Speed { get; set; }
        public string? Summary { get; set; }
        public string? SummaryMarkdown { get; set; }
        public string? Text { get; set; }
        public string? TraitMarkdown { get; set; }
        public string? Trigger { get; set; }
        public string? TriggerMarkdown { get; set; }
        public string? Type { get; set; }
        public string? Url { get; set; }
        public Dictionary<string, object>? Weakness { get; set; }
        public string? Cost { get; set; }
        public string? CostMarkdown { get; set; }
    }
}
