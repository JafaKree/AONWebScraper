using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterCreator.DataObjects
{
    public class ClassEntry
    {
        public List<string>? Attribute { get; set; }
        public List<string>? AttackProficiency { get; set; }
        public string? Category { get; set; }
        public List<string>? DefenseProficiency { get; set; }
        public bool? ExcludeFromSearch { get; set; }
        public string? FortitudeProficiency { get; set; }
        public int? Hp { get; set; }
        public string? HpRaw { get; set; }
        public string? IconImage { get; set; }
        public string? Id { get; set; }
        public List<string>? Image { get; set; }
        public string? Markdown { get; set; }
    }
}
