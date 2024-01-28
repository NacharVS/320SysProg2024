using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IInflictDamage
    {
        public void InflictDamage (IHealth change_health);
        public int Damage { get; set; }
        public static int LevelWeapon { get; set; }
    }
}
