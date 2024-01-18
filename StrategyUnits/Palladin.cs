using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        private int _minMagicDamage;
        private int _maxMagicDamage;
        private string _spell;
        private int _manaWaste;

        public int MinMagicDamage
        {
            get { return _minMagicDamage; }
            set { _minMagicDamage = value; }
        }
        public int MaxMagicDamage
        {
            get { return _maxMagicDamage; }
            set { _maxMagicDamage = value; }
        }

        public string Spell
        {
            get { return _spell; }
            set { _spell = value; }
        }

        private int ManaWaste
        {
            get { return _manaWaste; }
            set { _manaWaste = value; }
        }
        public Palladin() : base("Palladin", 65, 4, 6, "мечом", 2, 30)
        {
            _minMagicDamage = 7;
            _maxMagicDamage = 13;
            //Атаковал чем? В родительнои падеже
            _spell = "огненным заклинанием";
            _manaWaste = 10;
        }
        
        public void FireAttack(Unit unit)
        {
            if(Mana < ManaWaste && Alive)
            {
                Console.WriteLine($"{Name} имеет ману {Mana}/{MaxMana}. Чтобы атаковать {Spell} нужно минимум {ManaWaste} очков маны");
                return;
            }
            int baseMinDamage = MinDamage;
            int baseMaxDamage = MaxDamage;
            string baseWeapon = Weapon;
            MinDamage = MinMagicDamage;
            MaxDamage = MaxMagicDamage;
            Weapon = Spell;
            if (Attack(unit))
                Mana -= ManaWaste;
            MinDamage = baseMinDamage;
            MaxDamage = baseMaxDamage;
            Weapon = baseWeapon;
        }
    }
}
