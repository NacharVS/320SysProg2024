using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Forge
    {
        private int _armorlevel = 1;

        public int Armorlevel
        {
            get { return _armorlevel; }
            set { _armorlevel = value; }
        }


        private int _weaponlevel = 1;

        public int WeaponLevel
        {
            get { return _weaponlevel; }
            set { _weaponlevel = value; }
        }

        public void UpgradeWeapon(MilitaryUnit unit, string NameOfUnit)
        {

            if (unit.IsDead)
            {
                if (unit.WeaponLevel <= 3)
                {
                    unit.MaxDamage += 5;
                    unit.MinDamage += 5;
                    unit.WeaponLevel++;
                    Console.WriteLine($"Уровень повышен на 1!! Нынешний уровень: {unit.WeaponLevel}");
                }
                else
                {
                    Console.WriteLine($"Уровень оружия достиг максимального.");
                }
            }
            else
            {
                Console.WriteLine($"{unit.NameOfClass} мертв. Он не может прокачаться");
            }
        }

        public void UpgradeArmor(MilitaryUnit unit, string NameOfUnit)
        {

            if (unit.IsDead)
            {
                if (unit.Armorlevel <= 3)
                {
                    unit.Defense += 2;
                    unit.Armorlevel++;
                    Console.WriteLine($"Уровень повышен на 1!! Нынешний уровень: {unit.Armorlevel}");
                }
                else
                {
                    Console.WriteLine($"Уровень брони достиг максимального.");
                }
            }
            else
            {
                Console.WriteLine($"{unit.NameOfClass} мертв. Он не может прокачаться");
            }
        }



    }
}
