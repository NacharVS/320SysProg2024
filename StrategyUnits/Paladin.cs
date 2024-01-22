using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        public string _name;
        public int _damage;
        public int _health;
        public int _mana;
        private bool _holyArmor;
        public bool HolyArmor
        {
            get { return _holyArmor; }
            set { _holyArmor = value; }
        }
        public Paladin(string? name, int damage, int health, int mana) : base(name, damage, health, mana)
        {
            _name = name;
            _damage = damage;
            _health = health;
            _mana = mana;
        }
        public override int CurentHealth
        { get => base.CurentHealth;
            set
            {
                base.CurentHealth = value;
                double procent = Math.Round((double)CurentHealth / (double)_maxHealth, 4);
                if ((procent <= 0.5) && (Name == "Recruit"))
                {
                    
                    Rage = true;
                }
                if ((Rage == true) && (Name == "Recruit") && (procent > 0.5))
                {
                    Console.WriteLine($"Ульта включена.Предыдущий урон: {_damage}");
                    Damage *= 2;
                    Console.WriteLine($"Урон в данный момент {_damage}");
                    Rage = false;
                }
            }
        }
        
        public void HollyFire(Unit unit)
        {
            Console.WriteLine("Атакуем огнем");
            unit.PravHealth = unit.CurentHealth;
            if (unit.Suit)
            {
                unit.SuitHP -= _damage * 2;
                Mana -= 7;
                if (SuitHP <= 0)
                {
                    unit.SuitHP -= _damage * 2;
                    unit.CurentHealth += unit.SuitHP;
                    Console.WriteLine($"Брони больше нет. Атака {unit.SuitHP}.Здоровье {unit.CurentHealth}");
                    unit.Suit = false;
                }
            }
            else
                unit.CurentHealth -= _damage * 2;    
            Console.WriteLine($"{Name}. Mana: {Mana}");
        }
    }
}
