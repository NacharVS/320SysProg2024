using StrategyUnits.@interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{

    
    internal class MilitaryUnit : Unit, IBattleUnit 
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
                double procent = Math.Round((double)CurentHealth / (double)_maxHealth, 4);
                
                if ((Rage==true) && (Name == "Recruit") && (procent > 0.5))
                {
                    Console.WriteLine($"Ульта включена.Предыдущий урон: {_damage}");
                    Damage *= 2;
                    Console.WriteLine($"Урон в данный момент {_damage}");
                    Rage = false;
                }
                if (Rage && (procent >= 0.5) && Suit && (Name == "Paladin"))
                {
                    Console.Write($"Свещенная броня. Целостность брони: {SuitHP}");
                    SuitHP *= 2;
                    Console.WriteLine($"Целостность брони {SuitHP}");
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
