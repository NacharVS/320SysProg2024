using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _attack;
        private string _name;
        private int _health;
        private int _weaponlvl;
        public int WeaponLvl 
        {
            get { return _weaponlvl; }
            set { _weaponlvl = value; }
        }
        public int Attack
        {  get => _attack; set { _attack = value; } }
        public MilitaryUnit(int Damage, string Name, int health) : base(health, Name)
        {
            _attack = Damage;
            _name = Name;
            _health = health;
            _weaponlvl = 0;
        }
        public override int Health
        {
            get => base.Health;
            set 
            { 
                base.Health = value;
                double percent = Math.Round(((double)PrevHealth / (double)_maxHealth), 4);
                if ((Rrage) && (Name=="Berserker") && (percent >= 0.5))
                {
                    Console.Write("Rage's ON | Previous damage: " + _attack);
                    _attack *= 2;
                    Console.WriteLine("| Current damage: " + _attack);
                    Rrage = false;
                }
            }
        }
        virtual public void InflictDamage(Unit unit)
        {
            unit.PrevHealth = unit.Health;
            if (unit.Suit)
            {
                unit.SuitHP -= _attack;
                if (SuitHP <= 0)
                {
                    unit.SuitHP -= _attack;
                    unit.Health += unit.SuitHP;
                    Console.Write("Suit is broken");
                    Console.Write(" | Attack was " + unit.SuitHP);
                    Console.WriteLine(" | Current Health: " + unit.Health);
                    unit.Suit = false;

                }
            }
            else
                unit.Health -= _attack;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write($"| Damage: {_attack} ");
        }
    }
}
