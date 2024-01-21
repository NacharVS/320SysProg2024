using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    public class Forge
    {
        private int _armorLvl = 2;

        public int ArmorLvl
        {
            get { return _armorLvl; }
            set { _armorLvl = value; }
        }

        private int _weaponLvl = 2;

        public int WeaponLvl
        {
            get { return _weaponLvl; }
            set { _weaponLvl = value; }
        }

        public void UpgradeWeapons(List<MilitaryUnit> warriors)
        {
            if (WeaponLvl <= 3)
            {
                warriors.ForEach(x => x.MinDamage += 5);
                warriors.ForEach(x => x.MaxDamage += 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BLACKSMITH:\n"+$">> All the warriors levelled up their weapons to {WeaponLvl} LVL!\n");
                Console.ForegroundColor = ConsoleColor.White;
                WeaponLvl++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BLACKSMITH:\n" + $">> Your weapons are already great enough. No need to upgrade them.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void UpgradeArmor(List<MilitaryUnit> warriors)
        {
            if (ArmorLvl <= 3)
            {
                warriors.ForEach(x => x.Defense += 5);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BLACKSMITH:\n" + $">> All the warriors levelled up their armor to {ArmorLvl} LVL!\n");
                Console.ForegroundColor = ConsoleColor.White;
                ArmorLvl++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("BLACKSMITH:\n" + $">> Your armor is already brilliant. No need to upgrade it.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
