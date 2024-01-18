using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _damage;
        private string _name;
        private int _health;
        private int _mana;
        public MagicUnit(int Damage, string Name, int Health, int Mana) : base (Damage, Name, Health)
        {
            _damage = Damage;
            _name = Name;
            _health = Health;
            _mana = Mana;
        }
    }
}
