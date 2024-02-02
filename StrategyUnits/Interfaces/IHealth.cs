using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IHealth
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public bool IsDead { get; set; }
        public void DecreaseHealth(int damage);
        public void IncreaseHealth(int heal);
        public delegate void HealthChangedDelegate(string? name, int health, int health1, int maxHealth);
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
