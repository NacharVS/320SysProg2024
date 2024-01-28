using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfase
{
    internal interface IHealth
    {
        public int _health { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public bool Alive { get; set; }

        void TakeDamage (int damage);
        void RestoreHealth (int health);
    }
}
