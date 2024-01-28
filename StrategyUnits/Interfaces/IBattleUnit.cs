using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IBattleUnit
    {
        public int WeaponLvl { get; set; }
        public int Attack {  get; set; }
        public void InflictDamage(Unit unit);

    }
}
