using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicAttacker : MagicUnit
    {
        private int _magicDamage;
        private string _spell;
        private int _manaWaste;

        public int MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
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

        public MagicAttacker(string? name, int maxHealth, int damage, string weapon, 
            int maxMana, int magicDamage, string spell, int manaWaste) : base(name, maxHealth, damage, weapon, maxMana)
        {
            _magicDamage = magicDamage;
            _spell = spell;
            _manaWaste = manaWaste;
        }

        public void MagicAttack(Unit unit)
        {
            int baseDamage = Damage;
            string baseWeapon = Weapon;
            Damage = MagicDamage;
            Weapon = Spell;
            Attack(unit);
            Mana -= ManaWaste;
            Damage = baseDamage;
            Weapon = baseWeapon;
        }
    }
}
