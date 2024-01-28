using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IBattleUnit
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string Weapon { get; set; }
        public static int ExtraDamage { get; set; }
        public static int LevelExtraDamage { get; set; }
        public bool Attack(Unit unit);
    }
}
