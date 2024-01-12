using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : Unit
    {
        private int _mana;
        private int _maxMana;
        private bool _reboot = false;

        public int Mana
        {
            get { return _mana; }
            set 
            {
                if (value < 0)
                    _mana = 0;
                else if (value > _maxMana)
                    _mana = _maxMana;
                else
                    _mana = value; 
            }
        }

        public int MaxMana
        {
            get { return _maxMana; }
            set { _maxMana = value; }
        }

        public bool Reboot
        {
            get { return _reboot; }
            set { _reboot = value; }
        }

        public Healer() : base(40, "Healer")
        {
            _maxMana = 60;
            _mana = _maxMana;
        }


        public void HealSomeone(Unit unit)
        {
            if (!_reboot)
            {
                while (unit.MaxHealth - unit.Health > 0 && _mana > 0)
                {
                    unit.Health += 1;
                    _mana -= 2;
                }
            }
            else
            {
                Console.WriteLine("Healer reboot mana");
            }
        }

        public void HealSelf()
        {            
            if (!_reboot)
            {
                while (MaxHealth - Health > 0 && _mana > 0)
                {
                    Health += 2;
                    _mana -= 1;
                }
            }
            else
            {
                Console.WriteLine("Healer reboot mana");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} Mana: {_mana}");
        }

        public void GoAltar()
        {
            _mana = _maxMana;
            _reboot = true;
        }

        public void GoOutAltar()
        {
            _reboot = false;
        }
    }
}
