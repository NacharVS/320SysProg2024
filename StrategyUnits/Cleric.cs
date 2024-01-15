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
        
        public Cleric() : base("Cleric", 60, 5, 60, 60)
        {
           
        }

        public void HealYourself (Unit unit)
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
                    Console.WriteLine("Персонаж исцелился! Жизни = " + unit.Health);
                    return;
                }
                NowEnergy -= 1;
                unit.Health += 2;
            }
            Console.WriteLine("Персонаж исцелился! Жизни = " + unit.Health);
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
                    Console.WriteLine("Персонаж исцелился! Жизни = " + unit.Health);
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
            Console.WriteLine("Персонаж исцелился! Жизни = " + unit.Health);
        }

        

        public override void MagicAttack(Unit unit)
        {
            if (unit.DiedUnit)
            {
                Console.WriteLine($"Персонаж {unit.Name} мертв! Его нельзя атаковать!");
                return;
            }

            while (unit.DiedUnit == false || NowEnergy > 0)
            {
                NowEnergy -= 1;
                unit.Health -= 3;
            }
            Console.WriteLine($"Персонажу {unit.Name} нанесено максимальное количество урона с помощью магической атаки. Он мертв.");
        }
    }
}
