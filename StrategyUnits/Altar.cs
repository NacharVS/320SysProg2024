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
        private int _current_energy;
        public int _max_energy { get; private set; }

        private string? _name_altar;

        public string NameAltar
        {
            get { return _name_altar; }
            set { _name_altar = value; }
        }


        public int Energy
        {
            get => _current_energy;
            set
            {
                if (value < 0)
                    _current_energy = 0;
                else
                    if (value > _max_energy)
                    _current_energy = _max_energy;
                else
                    _current_energy = value;
            }
        }

        public Altar()
        {
            _name_altar = "Altar";
            _current_energy = 5000;
            _max_energy = _current_energy;
        }

        public void RestoreMana(MagicUnit MagicUnit) 
        {
            if(MagicUnit.Alive == false) 
            {
                Console.WriteLine($"{MagicUnit.Name} не может восстановить ману, он уже мертв");
                return;
            }
            if (MagicUnit.Alive) 
            {
                if (MagicUnit.Mana == MagicUnit._max_mana)
                {
                    Console.WriteLine($"{MagicUnit.Name} с полной маной");
                    return;
                }
                else if (Energy < 1)
                {
                    Console.WriteLine($"Алтарь не имеет достаточно маны для восстановления ману у {MagicUnit.Name}");
                    return;
                }
                else 
                {
                    while (Energy > 0 && MagicUnit.Mana < MagicUnit._max_mana)
                    {
                        MagicUnit.Mana += 10;
                        Energy -= 1;
                    }
                    Console.WriteLine($"{NameAltar} восстановил ману {MagicUnit.Name}");
                } 
            }
            else
                Console.WriteLine($"Алтарь не может восстановить ману у {MagicUnit.Name}, его с нами больше нет (╥_╥)");
        }



    }
}
