using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private int _mannaDamage;

        public Paladin(int health, string? name, int armor, int damage, int maxdamage, int manna) : base(health, name, armor, damage, maxdamage, manna)
        {
        }

        public event HealthChangedDelegate AttackPaladin;
        
        public override void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                int currentDamage;
                Random random = new Random();
                Damage = random.Next(Damage, MaxDamage);
                if (Health < MaxHealth / 2)
                {
                    HolyArmor();
                    currentDamage = Damage + _mannaDamage - unit.Armor;
                    unit.Health -= currentDamage;
                    Manna -= Manna - 2;
                }
                else
                {
                    currentDamage = Damage + _mannaDamage - unit.Armor;
                    unit.Health -= currentDamage;
                    Manna -= Manna - 2;
                }
                AttackPaladin.Invoke(Health, Name, Manna, Damage, unit.Health);
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }
        public void HolyArmor() 
        {
            Armor *= 2;
        }
    }
}