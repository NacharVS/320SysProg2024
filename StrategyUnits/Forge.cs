using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Forge
    {
        

        public void AppGradeOneAttack(MilitaryUnit unit)
        {
            if (unit.LvlappAttack == 0)
            {
                Console.WriteLine($"{unit.Name} have {unit._damage}/{unit.MaxDamage}");
                unit._damage += 1;
                unit.MaxDamage += 1;
                unit.LvlappAttack += 1;
                Console.WriteLine($"{unit.Name} улучшил свой урон до {unit.LvlappAttack} уровня. имеет теперь {unit._damage}/{unit.MaxDamage}");
            }
            else if (unit.LvlappAttack == 1)
            {
                Console.WriteLine($"{unit.Name} have {unit._damage}/{unit.MaxDamage}");
                unit._damage += 2;
                unit.MaxDamage += 2;
                unit.LvlappAttack += 1;
                Console.WriteLine($"{unit.Name} улучшил свой урон до {unit.LvlappAttack} уровня. имеет теперь {unit._damage}/{unit.MaxDamage}");
            }
            else
                Console.WriteLine("Макс уровень атаки, гуляй");
        }
        public void AppGradeOneArmor(Unit unit)
        {
            if (unit.LvlappArmor == 0)
            {
                unit.armor += 1;
                unit.LvlappArmor += 1;
            }
            else if (unit.LvlappArmor == 1)
            {
                unit.armor += 2;
                unit.LvlappArmor += 1;
            }
            else
                Console.WriteLine("Макс уровень атаки, гуляй");
        }
    }
}
