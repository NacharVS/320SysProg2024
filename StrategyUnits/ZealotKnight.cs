using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        public ZealotKnight(int health, string? name, int defense, int damage, int mana, int ArmorLvl, int WeaponLvl) : base(health, name, defense,mana, damage, ArmorLvl, WeaponLvl)
        {
        }

        public void Prayer(ZealotKnight zealotKnight)
        {
            if (zealotKnight.Alive)
            {
                if (zealotKnight.Health == zealotKnight.MaxHealth)
                {
                    Console.WriteLine($"{zealotKnight.Name} полностью здоров!");
                    return;
                }
                else if (Mana < 10)
                {
                    Console.WriteLine($"У {zealotKnight.Name} недостаточно маны,чтобы вылечить себя");
                    return;
                }
                else
                {
                    if (Mana >= 10 && zealotKnight.Health < zealotKnight.MaxHealth)
                    {
                        Console.WriteLine($"{zealotKnight.Name} вылечили себя на 20 HP");
                        zealotKnight.Health += 20;
                        Mana -= 10;
                    }
                }
            }
            else
                Console.WriteLine($"{zealotKnight.Name} не может вылечить себя, он уже мертв");
        }
    }
}
