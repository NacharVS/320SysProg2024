using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : Unit, IMagicUnit
    {
        private int _mana;
        public Healer(string? name, int health, int maxMana) : base(name, health)
        {
            MaxMana = maxMana;
            _mana = maxMana;
        }

        public int Mana
        {
            get => _mana;
            set
            {
                if (value < 0)
                    _mana = 0;
                else if (value > MaxMana)
                    _mana = MaxMana;
                else
                    _mana = value;
            }
        }
        public int MaxMana { get; set; }

        public void Heal(Unit unit)
        {
            while (Mana > 0 && unit.MaxHealth - unit.Health > 0)
            {
                unit.Health += 1;
                Mana -= 2;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} - Health: {Health}/{MaxHealth}, Mana: {Mana}");
        }
    }
}
