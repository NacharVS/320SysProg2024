using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        private int _manna;
        public int MaxManna { get; private set; }
        private int _damage;
        public event HealthChangedDelegate ClericHeal;
        public Cleric() : base(60, "Cleric")
        {
            _manna = 40;
            MaxManna = _manna;
        }
        public override void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                Random random = new Random();
                _damage = random.Next(5, 8);
                unit.Health -= _damage;
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }
        public void Heal(Unit unit)
        {
            if (unit.Alive)
            {
                if (unit == this)
                {
                    while (Manna >= 1 && unit.Health < unit.MaxHealth)
                    {
                        unit.Health += 2;
                        Manna -= 1;
                    }
                }
                else
                {
                    while (Manna >= 2 && unit.Health < unit.MaxHealth)
                    {
                        unit.Health += 1;
                        Manna -= 2;
                    }
                }
            }
            else
            {
                Console.WriteLine("Unit dead");
            }
        }

        public override void ShowInfo()
        {
            ClericHeal.Invoke(Health, Name, Manna, _damage);
        }
    }
}
