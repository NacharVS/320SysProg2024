using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        private int _defense;
        public ZealotKnight(string? name, int maxHP, int protection, int damage) : base(name, maxHP, protection, damage) { }
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
