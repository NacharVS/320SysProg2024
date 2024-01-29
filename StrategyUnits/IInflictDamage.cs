using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IInflictDamage
    {
        public int Damage { get; set; }
        public void InflictDamage(IHealth health);
        public static int LevelWeapon { get; set; }
    }
}
