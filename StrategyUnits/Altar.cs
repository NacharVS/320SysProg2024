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
        private string? _name;
        public Altar ()
        {
            _name = "Altar";
            _energy = 200;
            _maxEnergy = _energy;
        }
        public string Name
        { get => _name; set => _name = value; }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
            set { _maxEnergy = value; }
        }
        public int Energy
        {    get => _energy;
            set
            {
                if (value < 0)
                    _energy = 0;
                else
                    if (value > _maxEnergy)
                        _energy = _maxEnergy;
                    else
                        _energy = value;
            }
        }
        public void RecoverMana(MagicUnit unit)
        {
            if (unit.Dead)
            { Console.WriteLine("Dude is dead, oh, no.. We can't recover his mana("); return; }
            while (_energy > 0) 
            {
                if (unit.Mana < unit.MaxiMana) 
                { 
                    unit.PrevMana = unit.Mana;
                    unit.Mana += 5;
                    _energy -= 10;
                    Console.WriteLine($"Recover energy for {unit.Name}. Quantity of recovered mana: {unit.Mana-unit.PrevMana}. " +
                        $"Current mana from {unit.PrevMana} to {unit.Mana}/{unit.maxMana}");
                }
               if (unit.Mana >= unit.MaxiMana)
               {
                    Console.WriteLine("All mana's recovered");
                    break;
               } 
            }
            if (_energy == 0 )
            {
                Console.WriteLine("No energy... grustno:(");
            }
            
            
        }
        public void ShowInf() 
        {
            Console.WriteLine($"Unit: {_name} | Energy: {_energy}/{_maxEnergy}");
        }
    }
}
