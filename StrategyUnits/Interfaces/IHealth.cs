using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IHealth
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        public bool IsDead { get; set; }

        public void InflictkDamage(int damage);

        public void GetHeal(int heal);
    }
}
