using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Example
{
    internal class Throll : IHealth, IBattleUnit
    {
        public Throll()
        {
            Health = 80;
            Damage = 10;
        }

        public int Health { get; set; }
        public int Damage { get; set; }
        public int MaxHealth { get; set; }

        public void Attack(IHealth unit)
        {

            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
