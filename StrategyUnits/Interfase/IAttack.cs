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
        public static int WeaponLvl { get; set; }
        void InflictDamage(IHealth unit);

        public delegate void InflictDamageSmbd(string? Name, int damage);
        public event InflictDamageSmbd InflictDamageSmbdEvent;
    }
}
