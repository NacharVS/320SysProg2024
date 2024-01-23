using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        public int _damage; 
        public int MaxDamage { get;  set; }
        public event HealthChangedDelegate AttackEvent; 
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
                int currentDamage;
                Random random = new Random();
                Damage = random.Next(_damage, MaxDamage);
                currentDamage = Damage - unit.Armor;
                if(currentDamage > 0)
                {
                    unit.Health -= currentDamage;
                }
                else
                {
                    unit.Health -= 1;
                }
                AttackEvent.Invoke(Health, Name, null, Damage, unit.Health);
            }
            else
            {
                Console.WriteLine($"Unit {unit.Name} is dead");
            }
            
        }
    }
}