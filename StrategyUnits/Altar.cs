using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        private int _energy;
        private int _maxEnergy;

        public Altar()
        {
            _energy = 5000;
            _maxEnergy = _energy;
        }

        public int Energy
        {
            get { return _energy; }
            set
            {
                if (value < 0)
                    _energy = 0;
                else if (value > _maxEnergy)
                    _energy = _maxEnergy;
                else
                    _energy = value;
            }
        }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }

        public void RestoreMana(IMagicUnit unit)
        {
            if (Energy < 1)
            {
                Console.WriteLine($"Алтарь имеет энергию {Energy}/{MaxEnergy}. Для восстановаления маны нужно минимум 1 очко энергии алтаря");
            }
            Console.WriteLine($"{((Unit)unit).Name} восстанавливает ману в алтаре");
            int needRM = unit.MaxMana - unit.Mana;
            while (needRM % 10 != 0)
            {
                needRM++;
            }
            int possibleRM = Energy * 10;
            if (needRM <= possibleRM)
            {
                unit.Mana = unit.MaxMana;
                Energy -= needRM / 10;
            }
            else
            {
                unit.Mana += possibleRM;
                Energy -= possibleRM / 10;
            }
        }

        public Healer CreateHealer()
        {
            return new Healer("Healer", 50, 60);
        }

        public Paladin CreatePaladin()
        {
            return new Paladin("Paladin", 50, 3, 5, 10, 50);
        }

        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("Zealot knight", 50, 5, 7, 4, 55);
        }
    }
}
