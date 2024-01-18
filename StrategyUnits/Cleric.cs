using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        public Cleric() : base(50, "Safin", 4)
        {
            Mana = 50;
        }

        public void CureSomebody(Unit unit)
        {
            if (unit.Alive)
            {
                if (unit.Health == MaxHealth)
                {
                    Console.WriteLine($"{Name} полностью здоров");
                    return;
                }

                else if (Mana < 2)
                {
                    Console.WriteLine($"{Name} имеет недостаточно маны для лечения {unit.Name}");
                    return;
                }
                else
                {
                    while (Mana > 0 && unit.Health < unit.MaxHealth)
                    {
                        Console.WriteLine($"{Name} вылечил {unit.Name} на 1 HP.");
                        unit.Health += 1;
                        Mana -= 2;
                    }
                }
            }
            else
                Console.WriteLine($"Вы не можете вылечить {unit.Name}, его с нами больше нет (╥_╥)");

        }

        public void CureYourself(Cleric cleric)
        {
            if (cleric.Alive)
            {
                if (cleric.Health == cleric.MaxHealth)
                {
                    Console.WriteLine($"Вы полностью здоровы!");
                    return;
                }
                else if (Mana < 1)
                {
                    Console.WriteLine("У вас недостаточно маны,чтобы вылечить себя");
                    return;
                }
                else
                {
                    while (Mana > 0 && cleric.Health < cleric.MaxHealth)
                    {
                        Console.WriteLine("Вы вылечили себя на 2 HP. Ваше состояние здоровья...");
                        cleric.Health += 2;
                        Mana -= 1;
                    }
                }
            }
            else
                Console.WriteLine($"Вы не можете вылечить себя, вы уже мертвы");
        }

        public void RegenerationMana()
        {
            if (Alive)
            {
                Console.WriteLine($"Вы восстановили ману. Ваша мана равна {Mana}");
                Mana += 10;          
            }
            else
                Console.WriteLine($"{Name} не может восстановить ману,он мертв");
        }

        public override void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"Персонаж: {Name} Здоровья: {Health} Маны: {Mana}");
            else
                Console.WriteLine($"{Name} мертв ");
        }
    }
}
