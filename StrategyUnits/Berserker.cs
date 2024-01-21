using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public event HealthChangedDelegate AttackBerserker; 
        public Berserker() : base(60, "Berserker", 3, 9, 13)
        { 
        }
        public override void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                Random random = new Random();
                Damage = random.Next(Damage, MaxDamage);
                Damage = Damage - unit.Armor;
                if (Health < MaxHealth / 2)
                {
                    Rage();
                    unit.Health -= Damage;
                }
                else
                {
                    unit.Health -= Damage;
                }
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
            AttackBerserker.Invoke(Health, Name, null, Damage);
        }
        public void Rage()
        {
             Damage = Damage + Damage / 2;
        }
    }
}