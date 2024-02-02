using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal class Altar : Building
    {
        public Altar()
        {
            
        }
        public Cleric CreateCleric()
        {
            if (Energy >= 20)
            {
                Energy -= 20;
                Console.WriteLine("Призыв клерика");
                return new Cleric(20, 100);
            }
            return null;
        }
        public Paladin CreatePaladin()
        {
            if (Energy >= 30)
            {
                Energy -= 30;
                Console.WriteLine("Призыв паладина");
                return new Paladin(40, 120);
            }
            return null;

        }
        public void HealAltar(IMagicUnit unit)
        {
            while (unit.Mana < unit.MaxMana)
            {
                Energy -= 1;
                unit.Mana += 10;
            }
        }

    }
}
