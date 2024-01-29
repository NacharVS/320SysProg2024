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

        public delegate void RegenerateHealthChange(string? Name, int _health, int _current_health, int MaxHealth);
        public delegate void DecreasedHealthChange(string? Name, int _health, int _current_health, int MaxHealth);
        public event RegenerateHealthChange RegenerateHealthChangeEvent;
        public event DecreasedHealthChange DecreasedHealthChangeEvent;

        void TakeDamage (int damage);
        void RestoreHealth (int health);
    }
}
