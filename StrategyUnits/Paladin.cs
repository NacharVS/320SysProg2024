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
        public event HealthChangedDelegate AttackPaladin;
        public Paladin() : base(70, "Paladin", 5, 7, 10, 40)
        {
            _mannaDamage = 5;
        }
        public override void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                Random random = new Random();
                Damage = random.Next(Damage, MaxDamage);
                Damage = Damage + _mannaDamage;
                Damage = Damage - unit.Armor;
                unit.Health -= Damage;
                Manna -= Manna - 2;
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
            AttackPaladin.Invoke(Health, Name, Manna, Damage);
        }
    }
}