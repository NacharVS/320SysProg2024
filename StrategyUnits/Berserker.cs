using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        int currentDamage;
        public Berserker(int health, string? name, int armor, int damage, int maxdamage) : base(health, name, armor, damage, maxdamage)
        {
        }

        public event HealthChangedDelegate AttackBerserker;

        public override void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                
                Random random = new Random();
                Damage = random.Next(_damage, MaxDamage);
                currentDamage = Damage - unit.Armor;
                if (currentDamage > 0)
                {
                    if (Health < MaxHealth / 2)
                    {
                        Rage();
                        unit.Health -= currentDamage;
                    }
                    else
                    {
                        unit.Health -= currentDamage;
                    }
                }
                else
                {
                    unit.Health -= 1;
                }
                AttackBerserker.Invoke(Health, Name, null, Damage, unit.Health);
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }
        public void Rage()
        {
            _damage *= 2;
            MaxDamage *= 2;
        }
    }
}