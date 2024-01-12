using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Healer : Unit
    {
        private int _mana;
        public int MaxMana
        {
            get { return _mana; }
            set { MaxMana = value; }
        }
        public int Mana
        {
            get { return _mana; }
            set {
                if (value < 0)
                    _mana = 0;
                else 
                    if (_mana > MaxMana)
                        _mana = MaxMana; 
                    else
                        _mana = value; }
        }
        public Healer() : base(50, "Healer")
        {
            _mana = 50;
        }
        public void ToHeal(Unit unit)
        {
            while (Mana > 0)
            {
                if (unit.Name == "Healer")
                {
                    unit.Health += 1;
                    Mana -= 2;
                }
                else
                {
                    unit.Health += 2;
                    Mana -= 1;
                }
            }
        }
        public void ShowMana()
        {
            Console.WriteLine("Mana: " + Mana);
        }
    }
}
