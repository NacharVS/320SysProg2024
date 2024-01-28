using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Interfase
{
    internal interface IAttack
    {
        public int Damage { get; set; }
        public int WeaponLvl { get; set; }
        void InflictDamage(IHealth unit);

    }
}
