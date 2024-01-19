using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        public ZealotKnight(double health, string? name, double damage, double maxEnergy, double protection) : base(health, name, damage, maxEnergy, protection)
        {

        }

        public void Prayer()
        {
            if(CurrentEnergy >= 10)
            {
                CurrentHealth += 20;
                CurrentEnergy -= 10;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Недостаточно очков энергии для регенерации здоровья");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {CurrentHealth}/{MaxHealth} Damage: {Damage} Protection {Protection}");
        }
    }
}
