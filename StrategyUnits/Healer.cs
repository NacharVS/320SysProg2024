using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer(): base(60, "Healer")
        {
            _mana = 60;
            _maxMana = 60;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Здоровье: {CurentHealth} Максимальное здоровье: {MaxHealth} Мана: {Mana}");
        }
    }
}
    

