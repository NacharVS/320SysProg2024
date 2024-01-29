using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal class Berserker : Unit, IBattleUnit
    {
        public Berserker(int health) : base(health)
        {
        }

        public int MinDamage { get ; set ; }
        public int Protection { get ; set; }
        private int _maxDamage;
        public int MaxDamage
        {
            get
            {
                if (Health < MaxHealth * 0.5)
                    return _maxDamage * 2;
                else
                    return _maxDamage;
            }
            set { _maxDamage = value; }
        }

        public void Attack(Unit unit)
        {
            Random rnd = new Random();
            unit.TakeDamage(rnd.Next(MinDamage, MaxDamage));
        }

        public override void TakeDamage(int damage)
        {
            if (!IsAlive)
            {
                Console.WriteLine("Unit is death");
                return;
            }

            else if (damage > Protection)
                Health -= damage - Protection;

            if (Health < 0)
            {
                IsAlive = false;
                Health = 0;
            }
        }
    }
}
