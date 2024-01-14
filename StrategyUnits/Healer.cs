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
        public int maxMana
        { get { return _mana; } 
          set { _mana = value; } 
        }
        public Healer(int manaValue): base(60, "Healer")
        {
            maxMana = manaValue;
        }

        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                    _mana = 0;
                else
                    if (_mana > maxMana)
                    _mana = maxMana;
                else
                    _mana = value;
            }
        }
        public void Heal(Unit unit)
        {
            if (unit.Dead == true)
            {
                Console.WriteLine("Unit мертв.");
                return;
            }

            while (_mana > 0)
            {
                    if (unit.CurentHealth < unit.MaxHealth)
                    {
                        _mana -= 2;
                        Console.WriteLine($"Healed from {unit.CurentHealth} to {unit.CurentHealth + 1}; Mana left: {_mana}");
                        unit.Health++;
                    }
                    if (unit.CurentHealth >= unit.MaxHealth)
                    {
                        Console.WriteLine($"Исцелился.");
                        break;
                    }
            }
                if (Mana == 0)
                {
                    Console.WriteLine("Mana закончилась!");
                }

            
        }

        public void Healself()
        {
            if (Dead == true)
            {
                Console.WriteLine("Unit мертв");
                return;
            }
            while (_mana > 0)
            {
                if (Health < MaxHealth)
                {
                    _mana--;
                    int finalHealth = Health + 2;
                    if (MaxHealth >= MaxHealth)
                        Health = MaxHealth;
                    else
                        Health += 2;
                    Console.WriteLine($"Healed from {Health} to {finalHealth}; Mana left: {_mana}");
                    //Health += 2;
                }
                if (Health >= MaxHealth)
                {
                    Console.WriteLine($"Исцелился.");
                    break;
                }
            }
            if (Mana == 0)
            {
                Console.WriteLine("Mana закончилась!");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} MaxHealth: {MaxHealth} Mana: {Mana}");
        }
    }
}
    

