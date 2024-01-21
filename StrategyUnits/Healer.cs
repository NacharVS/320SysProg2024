using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer(int health, string? name, int mana) : base(health, name, mana)
        {
            _mana = mana;       
        }
        public Healer(): base(60, "Healer", 60)
        {
            _mana = 60;
            _maxMana = 60;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Здоровье: {CurentHealth}/{MaxHealth} Мана: {_mana}");
        }
    }
}
    

