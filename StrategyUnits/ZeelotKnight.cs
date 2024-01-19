using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class ZeelotKnight : MagicUnit
    {
        private int _defense;

        public ZeelotKnight(int maxHP, string? name, int damage) : base(maxHP, name, damage) { }

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public void Prayer(Unit unit)
        {
            if (DeadUnit == false)
            {
                CurrentHP += 20;
                Mana -= 10;
            }
            else
            {
                Console.WriteLine("Unit is dead.");
            }
        }
    }
}
