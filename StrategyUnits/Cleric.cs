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
        //public int MaxManna { get; private set; }
        //private int _damage;
        public event HealthChangedDelegate ClericHeal;
        public Cleric(int health, string? name, int armor, int damage, int maxdamage, int manna) : base(health, name, armor, damage, maxdamage, manna)
        {
        }

        public void Heal(Unit unit)
        {
            if (unit.Alive)
            {
                if (unit == this)
                {
                    while (Manna >= 1 && unit.Health < unit.MaxHealth)
                    {
                        unit.Health += 2; Manna -= 1;
                    }
                }
                else
                {
                    while (Manna >= 2 && unit.Health < unit.MaxHealth)
                    {
                        unit.Health += 1; Manna -= 2;
                    }
                }
                ClericHeal.Invoke(Health, Name, Manna, Damage, unit.Health);
            }
            else
            {
                Console.WriteLine("Unit dead");
            }
        }
        //public override void ShowInfo()
        //{
        //    ClericHeal.Invoke(Health, Name, Manna, Damage, null);
        //}
    }
}