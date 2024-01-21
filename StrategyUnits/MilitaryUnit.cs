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
        

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        
        public MilitaryUnit(int health, string? name, int damage) : base(health, name)
        {
            _damage = damage;
        }

        public override int CurentHealth 
        { get => base.CurentHealth;
            set 
            { 
                base.CurentHealth = value;
                double procent = Math.Round(((double)PravHealth) /((double) _maxHealth), 4);
                Console.WriteLine($"Procent suka {procent}");
                Console.WriteLine(procent);
                if ((Rage==true) && (Name == "Recruit") && (procent > 0.5))
                {
                    Damage *= 2;
                    Console.WriteLine("damage "+_damage);
                    Rage = false;
                }
            }
        }
        public void InflictDamage(Unit unit)
        {
            unit.PravHealth = unit.CurentHealth;
            unit.CurentHealth -= _damage;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж {Name} Атака: {_damage} Здоровье:{CurentHealth}/{MaxHealth}");
        }
    }
}
