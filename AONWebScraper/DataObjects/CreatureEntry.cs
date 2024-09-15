using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterCreator.DataObjects
{
    public class CreatureEntry
    {
        public int? Ac { get; set; }
        public string? AcScale { get; set; }
        public int? AcScaleNumber { get; set; }
        public string? Alignment { get; set; }
        public string? Category { get; set; }
        public int? Charisma { get; set; }
        public string? CharismaScale { get; set; }
        public int? CharismaScaleNumber { get; set; }
        public int? Constitution { get; set; }
        public string? ConstitutionScale { get; set; }
        public int? ConstitutionScaleNumber { get; set; }
        public List<string>? CreatureAbility { get; set; }
        public string? CreatureFamilyMarkdown { get; set; }
        public int? Dexterity { get; set; }
        public string? DexterityScale { get; set; }
        public int? DexterityScaleNumber { get; set; }
        public bool? ExcludeFromSearch { get; set; }
        public int? FortitudeSave { get; set; }
        public string? FortitudeSaveScale { get; set; }
        public int? FortitudeSaveScaleNumber { get; set; }
        public int? Hp { get; set; }
        public string? HpRaw { get; set; }
        public string? HpScale { get; set; }
        public int? HpScaleNumber { get; set; }
        public string? Id { get; set; }
        public List<string>? Immunity { get; set; }
        public string? ImmunityMarkdown { get; set; }
        public int? Intelligence { get; set; }
        public string? IntelligenceScale { get; set; }
        public int? IntelligenceScaleNumber { get; set; }
        public List<string>? Language { get; set; }
    }
}
