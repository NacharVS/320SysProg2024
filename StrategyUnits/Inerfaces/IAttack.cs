using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Inerfaces
{
    internal interface IAttack
    {
        public void Attack(IHealth currentHealth);
        public double Damage { get; set; }
    }
}
