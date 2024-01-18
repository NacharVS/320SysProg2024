using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        public Altar()
        {
            _energ = 2000;
            _maxEherg = 2000;
        }
        public int _energ;
        public int _maxEherg;
        public int Maxenerg
        {
            get { return _maxEherg; }
            set { _maxEherg = value; }
        }
        public int Energ
        {
            get { return _energ; }
            set
            {
                if (value < 0)
                    _energ = 0;
                else
                    if (_energ > _maxEherg)
                    _energ = _maxEherg;
                else
                    _energ = value;
            }
        }
        public void RecHeal(MagicUnit magicUnit)
        {
            if (magicUnit.Dead == true)
            {
                Console.WriteLine($"{magicUnit.Name} мертв.");
                return;
            }
            else
            {
                while (_energ > 0)
                {
                    if (magicUnit.Mana < magicUnit.MaxMana)
                    {
                        _energ -= 1;
                        Console.WriteLine($"Мана от {magicUnit.Mana} до {magicUnit.Mana + 10}; Остатки энергии алтаря: {_energ}");
                        magicUnit.Mana = magicUnit.Mana + 10;

                    }
                    if (magicUnit.Mana >= magicUnit.MaxMana)
                    {
                        Console.WriteLine($"Исцелился.");
                        break;
                    }
                }
                if (Energ == 0)
                {
                    Console.WriteLine("Энергия закончилась!");
                }
            }

        }
    }
}
