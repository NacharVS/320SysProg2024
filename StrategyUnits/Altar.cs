using StrategyUnits.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static StrategyUnits.Interfase.IMana;

namespace StrategyUnits
{
    internal class Altar : IMana, IInfoAboutSmth
    {
        private string? _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public event RegenerateMana RegenerateManaEvent;
        public event DecreasedMana DecreasedManaEvent;

        public int _current_mana { get; set; }
        public int _max_mana { get; set; }
        public int Mana
        {
            get => _current_mana;
            set
            {
                if (value < 0)
                    _current_mana = 0;
                else
                    if (value > _max_mana)
                    _current_mana = _max_mana;
                else
                if (_current_mana < value)
                {
                    RegenerateManaEvent.Invoke(Name, _current_mana, value, _max_mana);
                }
                else
                {
                    DecreasedManaEvent.Invoke(Name, _current_mana, value, _max_mana);
                }
                _current_mana = value;
            }
        }

        public Altar()
        {
            _name = "Altar";
            _current_mana = 5000;
            _max_mana = _current_mana;
        }

        public void RestoreMana(IMana MagicUnit)
        {

            if (MagicUnit.Mana == MagicUnit._max_mana)
            {
                Console.WriteLine($"Персонаж с полной маной");
                return;
            }
            else if (Mana < 1)
            {
                Console.WriteLine($"Алтарь не имеет достаточно маны для восстановления маны");
                return;
            }
            else
            {
                while (Mana > 0 && MagicUnit.Mana < MagicUnit._max_mana)
                {
                    MagicUnit.RegenerationMana(10);
                    SpendMana(1);
                }
                Console.WriteLine($"{Name} восстановил ману верующему ");
            }
        }

        public Cleric CreateCleric()
        {
            return new Cleric(50, "Cleric", 50, 4, 8, 1, 1);
        }
        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight(80, "ZealotKnight", 7, 12, 30, 1, 1);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin(100, "Paladin", 7, 15, 30, 1, 1);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название алтаря: {Name}, Состояние энергии: {Mana}/{_max_mana}");
        }

        public void RegenerationMana(int mana)
        {
            Mana += mana;
        }

        public void SpendMana(int mana)
        {
            Mana -= mana;
        }
    }
}
