using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _manna;
        public Cleric() : base(30, "Cleric")
        {
            _manna = 40;
        }
        public int Manna
        {
            get { return _manna; }
            set { _manna = value; }
        }

        public void selfHeal()
        {
            while (Manna >= 1)
            {
                Health += 2;
                Manna -= 1;
            }
        }

        public void Heal(Unit unit)
        {
            if (unit.isAlive)
            {
                while (Manna >= 2)
                {
                    unit.Health += 1;
                    Manna -= 2;
                }
            }
            else
            {
                Console.WriteLine("Unit is dead");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} Manna: {Manna}" );
        }
    }
}
