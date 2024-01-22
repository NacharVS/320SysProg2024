using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        
        public Cleric(string? name, double health, double damage, double defence, double maxEnergy) : base(name, health, damage, defence, maxEnergy)
        {
           
        }

        public void HealOther (Unit unit)
        {
            if (unit.DiedUnit)
            {
                Console.WriteLine("Персонаж мертв! Лечить нельзя!");
                return;
            }
            while (NowEnergy > 0)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    return;
                }
                if (NowEnergy < 2)
                {
                    Console.WriteLine("Для восстановления жизни другого персонажа необходимо минимум 2 очка энергии!");
                    break;
                }
                NowEnergy -= 2;
                unit.Health += 1;
            }
            
        }

        
    }
}
