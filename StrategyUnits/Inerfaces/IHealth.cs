using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Inerfaces
{
    internal interface IHealth
    {
        public double CurrentHealth { get; set; }
        public bool IsDied { get; set; }
        public double MaxHealth { get; set; }
        public void DecreaseHealth(double damage);
        public void IncreseHealth(double health);

    }
}
