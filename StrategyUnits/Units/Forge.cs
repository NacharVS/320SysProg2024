using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Forge : IGeneralInformation
    {
        public Forge(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }

        public void UpdateWeapons()
        {
            if (IAttack.LvlWeapon < 2)
                IAttack.LvlWeapon++;
            else
                Console.WriteLine("Достигнут максимальный уровень возможной прокачки оружия");
        }
        public void UpdateArmor()
        {
            if (IArmoredUnit.LvlArmor < 2)
                IArmoredUnit.LvlArmor++;
            else
                Console.WriteLine("Достигнут максимальный уровень возможной прокачки брони");
        }

        public void ShowInformation()
        {
            Console.WriteLine($" Персонаж: {Name}\n");
        }
    }
}
