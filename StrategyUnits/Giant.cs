using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Giant : IHealth, IBattleUnit, IArmoredUnit
    {
        public Giant()
        {
            Health = 60;
            Damage = 5;
            Defense = 3;
        }

        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }

        public void Attack(IHealth unit)
        {
            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Defense;
        }
    }
}
