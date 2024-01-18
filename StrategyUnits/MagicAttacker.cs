using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicAttacker : MagicUnit
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

        public MagicAttacker(string? name, int maxHealth, int minDamage, int maxDamage, string weapon, int shield,
            int maxMana, int minMagicDamage, int maxMagicDamage, string spell, int manaWaste) 
            : base(name, maxHealth, minDamage, maxDamage, weapon, shield, maxMana)
        {
            _minMagicDamage = minMagicDamage;
            _maxMagicDamage = maxMagicDamage;
            _spell = spell;
            _manaWaste = manaWaste;
        }

        public void MagicAttack(Unit unit)
        {
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
