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
        private int _maxEnergy;
        private int _nowEnergy;

        public int NowEnergy
        {
            get { return _nowEnergy; }
            set
            {
                if (value > MaxEnergy)
                    _nowEnergy = _maxEnergy;
                else if (value < 0)
                    _nowEnergy = 0;
                else
                    _nowEnergy = value;
            }
        }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }

        public Cleric() : base(60, "Cleric")
        {
           _maxEnergy = 60;
           _nowEnergy = _maxEnergy;
        }

        public void HealYourself (Unit unit)
        {
            if (unit.DiedUnit)
            {
                Console.WriteLine("Персонаж мертв! Лечить нельзя!");
                return;
            }
            while (_nowEnergy > 0)
            {
               
                if (unit.MaxHealth <= unit.Health)
                {
                    Console.WriteLine("Персонаж исцелился! Жизни = " + unit.Health);
                    return;
                }
                _nowEnergy -= 1;
                unit.Health += 2;
            }
            Console.WriteLine("Персонаж исцелился! Жизни = " + unit.Health);
        }

        public void HealOther (Unit unit)
        {
            if (unit.DiedUnit)
            {
                Console.WriteLine("Персонаж мертв! Лечить нельзя!");
                return;
            }
            while (_nowEnergy > 0)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    Console.WriteLine("Персонаж исцелился! Жизни = " + unit.Health);
                    return;
                }
                if (_nowEnergy < 2)
                {
                    Console.WriteLine("Для восстановления жизни другого персонажа необходимо минимум 2 очка энергии!");
                    break;
                }
                _nowEnergy -= 2;
                unit.Health += 1;
            }
            Console.WriteLine("Персонаж исцелился! Жизни = " + unit.Health);
        }

        public void ReconstructionEnergy()
        {
            NowEnergy = MaxEnergy;
            Console.WriteLine("Энергия восстановлена до максимума");
        }

        public void ShowInfoEnergy()
        {
            Console.WriteLine($"Энергия персонажа = {NowEnergy}");
        }
    }
}
