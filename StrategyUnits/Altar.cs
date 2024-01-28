using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Altar
    {
        private int _energy;
        private int _maxEnergy;

        public int Energy
        {
            get { return _energy; }
            set
            {
                if (value > Energy)
                {
                    //if (value > MaxEnergy)
                    //    value = MaxEnergy;
                    //Console.WriteLine($"Ал восстановил ману на {value - Mana}. Текущая мана {value}/{MaxMana}");
                }
                else
                {
                    int waste = Energy - value;
                    if (value < 0)
                        value = 0;
                    Console.WriteLine($"В алтаре потратилась энергия {waste}. Текущая энергия алтаря {value}/{MaxEnergy}");
                }
                if (value <= 0)
                {
                    _energy = 0;
                    Console.WriteLine("В алтаре не осталось энергии");
                }
                else if(value > _maxEnergy)
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

        public Altar()
        {           
            _energy = 5000;
            _maxEnergy = _energy;
        }

        public void RestoreMana(IMagicUnit unit)
        {
            if (!((Unit)unit).Alive)
            {
                Console.WriteLine($"{((Unit)unit).Name} мертв. Он не может восстанавливать ману в алтаре");
                return;
            }
            if (unit.Mana == unit.MaxMana)
            {
                Console.WriteLine($"{((Unit)unit).Name} имеет полную ману. Не нужно восстанавливать в алтаре");
                return;
            }
            if (Energy < 1)
            {
                Console.WriteLine($"Алтарь имеет энергию {Energy}/{MaxEnergy}. Для восстановаления маны нужно минимум 1 очко энергии алтаря");
                return;
            }
            Console.WriteLine($"{((Unit)unit).Name} восстанавливает ману в алтаре");
            int needRestore = unit.MaxMana - unit.Mana;
            while(needRestore % 10 != 0)
            {
                needRestore++;
            }
            int possibleRestore = Energy * 10;
            if (needRestore <= possibleRestore)
            {
                unit.Mana = unit.MaxMana;
                Energy -= needRestore / 10;
            }
            else
            {
                unit.Mana += possibleRestore;
                Energy -= possibleRestore / 10;
            }
        }

        public Healer CreateHealer()
        {
            return new Healer("Healer", 45, 50);
        }

        public Palladin CreatePalladin()
        {
            return new Palladin("Palladin", 65, 4, 6, "мечом", 2, 30, 7, 15, "огненным заклинанием", 10);
        }

        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("ZealotKnight", 50, 4, 7, "клинком", 4, 40);
        }
    }
}
