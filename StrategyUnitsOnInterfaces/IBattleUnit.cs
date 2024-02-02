using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal interface IBattleUnit
    {
        public int MinDamage { get; set; }

        public int MaxDamage { get; set; }

        public int Protection { get; set; }
        public int LevelWeapon { get; set; }
        public int LevelArmor { get; set; }


        public abstract void Attack(Unit unit);
    }
}
