using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _mana;
        private int _maxMana;

        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                    _mana = 0;
                else if (value > _maxMana)
                    _mana = _maxMana;
                else
                    _mana = value;
            }
        }

        public int MaxMana
        {
            get { return _maxMana; }
            set { _maxMana = value; }
        }

        public MagicUnit(int maxHealth, string? name, int damage, int maxMana) : base(maxHealth, name, damage)
        {
            _maxMana = maxMana;
            _mana = maxMana;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Mana: {Mana}/{MaxMana}");
        }
    }
}
