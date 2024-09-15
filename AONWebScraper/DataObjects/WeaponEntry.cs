using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterCreator.DataObjects
{
    public class WeaponEntry
    {
        public string? AmmunitionMarkdown { get; set; }
        public int? Bulk { get; set; }
        public string? Category { get; set; }
        public string? Damage { get; set; }
        public int? DamageDie { get; set; }
        public List<string>? DamageType { get; set; }
        public List<string>? Deity { get; set; }
        public string? DeityMarkdown { get; set; }
        public bool? ExcludeFromSearch { get; set; }
        public string? Hands { get; set; }
        public string? Id { get; set; }
        public string? ItemCategory { get; set; }
        public string? ItemSubcategory { get; set; }
        public int? Level { get; set; }
        public string? Markdown { get; set; }
        public string? Name { get; set; }
        public string? Pfs { get; set; }
        public string? PrimarySource { get; set; }
        public string? PrimarySourceRaw { get; set; }
        public string? PrimarySourceCategory { get; set; }
        public string? Rarity { get; set; }
        public int? RarityId { get; set; }
        public string? ReleaseDate { get; set; }
        public string? RemasterId { get; set; }
        public Dictionary<string, object>? Resistance { get; set; }
        public string? SearchMarkdown { get; set; }
    }
}
