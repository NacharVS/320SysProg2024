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
        public ZealotKnight(int health, string? name, int damage, int maxEnergy, int protection) : base(health, name, damage, maxEnergy, protection)
        {

        }

        public void Prayer()
        {
            if(CurrentEnergy >= 10)
            {
                CurrentHealth += 20;
                CurrentEnergy -= 10;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {CurrentHealth}/{MaxHealth} Damage: {Damage} Protection {Protection}");
        }
    }
}
