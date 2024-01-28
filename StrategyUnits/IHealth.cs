using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyUnits.Unit;

namespace StrategyUnits
{
    internal interface IHealth
    {
        public int Change_Health { get; set; }
        public bool DeadPerson { get; set; }
        public int MaxHealth { get; set; }
        public void DecreaseHealth (int damage);
        public void IncreaseHealth (int health);

        public delegate void HealthChangeDelegate(int _change_health, string? name, int change, int maxHealth);
        public event HealthChangeDelegate HealthDecreasedEvent;
        public event HealthChangeDelegate HealthIncreasedEvent;
    }
}
