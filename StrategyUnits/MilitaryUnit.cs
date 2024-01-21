using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damage; public int MaxDamage { get; private set; }
        public event HealthChangedDelegate MilitaryUnitDamage; 
        public MilitaryUnit(int health, string? name, int armor, int damage, int maxdamage) : base(health, name, armor)
        {
            _damage = damage;
            MaxDamage = maxdamage;
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public virtual void Attack(Unit unit)
        {
            if (unit.Alive)
            {
                Random random = new Random();
                Damage = random.Next(_damage, MaxDamage);
                Damage = Damage - unit.Armor;
                unit.Health -= Damage;
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }
    }
}