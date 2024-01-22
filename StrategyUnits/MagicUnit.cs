using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _current_mana;
        public int _max_mana { get; private set; }

        private int _magic_damage;

        public int MagicDamage
        {
            get { return _magic_damage; }
            set { _magic_damage = value; }
        }

        public int Mana
        {
            get => _current_mana;
            set
            {
                if (value < 0)
                    _current_mana = 0;
                else
                    if (value > _max_mana)
                    _current_mana = _max_mana;
                else
                    _current_mana = value;
            }
        }
        public MagicUnit(int health, string? name, int defense,int damage,int mana,int ArmorLvl, int WeaponLvl) : base(health, name, defense, damage, ArmorLvl, WeaponLvl)
        {
            _current_mana = 50;
            _max_mana = _current_mana;
        }
    }
}
