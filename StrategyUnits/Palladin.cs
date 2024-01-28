using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : ZealotKnight
    {
        private int _minMagicDamage;
        private int _maxMagicDamage;
        private string? _spell;
        private int _manaWaste;
        private bool _holyArmorActive = false;

        public Palladin(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int shield, int maxMana,
            int minMagicDamage, int maxMagicDamage, string spell, int manaWaste) 
            : base(name, maxHealth, minDamage, maxDamage, weapon, shield, maxMana)
        {
            _minMagicDamage = minMagicDamage;
            _maxMagicDamage = maxMagicDamage;
            _spell = spell;
            _manaWaste = manaWaste;
        }

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



        
        public void MagicAttack(Unit unit)
        {
            if(Mana < ManaWaste && Alive)
            {
                Console.WriteLine($"{Name} имеет ману {Mana}/{MaxMana}. Чтобы атаковать {Spell} нужно минимум маны {ManaWaste}");
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

        public void HolyArmor()
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может активировать святую защиту");
                return;
            }
            if (_holyArmorActive)
            {
                Console.WriteLine($"{Name} уже активировал святую защиту");
                return;
            }
            if (Mana < 12)
            {
                Console.WriteLine($"{Name} имеет ману {Mana}/{MaxMana}. Для святой защиты нужно минимум 12 очков маны");
                return;
            }
            Armor += 2;
            Console.WriteLine($"{Name} активировал святую защиту. Текущая защита {Armor + IArmoredUnit.ExtraArmor}");
            _holyArmorActive = true;
            Mana -= 12;            
        }
    }
}
