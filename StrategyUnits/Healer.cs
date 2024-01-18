using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer() : base("Healer", 45, 1, 4, "посохом", 1, 50)
        {
        }

        public void HealSomeone(Unit unit)
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может лечить");
                return;
            }
            if (!unit.Alive)
            {
                Console.WriteLine($"{unit.Name} мертв. Его нельзя лечить");
                return;
            }
            if(unit.Health == unit.MaxHealth)
            {
                Console.WriteLine($"{unit.Name} имеет полное здоровье. Лечение не нужно");
                return;
            }
            if(Mana < 2)
            {
                Console.WriteLine($"{Name} имеет ману {Mana}/{MaxMana}. Для лечения другого нужно минимум 2 очка маны");
                return;
            }
            Console.WriteLine($"{Name} начал лечить {unit.Name}");
            int needHeal = unit.MaxHealth - unit.Health;
            int possibleHeal = Mana / 2;
            if( needHeal <= possibleHeal)
            {
                unit.Health = unit.MaxHealth;
                Mana -= needHeal * 2;
            }
            else
            {
                unit.Health += possibleHeal;
                Mana -= possibleHeal * 2;
            }
        }

        public void HealSelf()
        {
            if(!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может лечить");
                return;
            }
            if (Health == MaxHealth)
            {
                Console.WriteLine($"{Name} имеет полное здоровье. Лечение не нужно");
                return;
            }
            if (Mana == 0)
            {
                Console.WriteLine($"{Name} имеет ману 0/{MaxMana}. Для лечения себя нужно минимум 1 очко маны");
                return;
            }
            Console.WriteLine($"{Name} начал лечить сам себя");
            int needHeal = MaxHealth - Health;
            if (needHeal % 2 != 0)
                needHeal += 1;
            int possibleHeal = Mana * 2;
            if (needHeal <= possibleHeal)
            {
                Health = MaxHealth;
                Mana -= needHeal / 2;
            }
            else
            {
                Health += possibleHeal;
                Mana -= possibleHeal / 2;
            }
        }
    }
}
