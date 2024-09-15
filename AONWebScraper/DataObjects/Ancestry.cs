using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PathfinderCharacterCreator.DataObjects
{
    public class Navigation
    {
        public string? Label { get; set; }
        public string? Url { get; set; }
    }

    public class AncestryEntry
    {
        public List<string>? Attribute { get; set; }
        public List<string>? AttributeFlaw { get; set; }
        public string? Category { get; set; }
        public bool ExcludeFromSearch { get; set; }
        public int Hp { get; set; }
        public string? HpRaw { get; set; }
        public string? Id { get; set; }
        public List<string>? Image { get; set; }
        public List<string>? Language { get; set; }
        public string? LanguageMarkdown { get; set; }
        public string? Markdown { get; set; }
        public string? Name { get; set; }
        public List<Navigation>? Navigation { get; set; }
        public string? PrimarySource { get; set; }
        public string? PrimarySourceRaw { get; set; }
        public string? PrimarySourceCategory { get; set; }
        public string? Rarity { get; set; }
        public int RarityId { get; set; }
        public string? ReleaseDate { get; set; }
        public string? RemasterId { get; set; }
    }
}
