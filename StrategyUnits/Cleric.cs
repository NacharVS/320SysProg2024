using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _Current_Mana;
        public int Max_Mana { get; private set; }

        public int Mana
        {
            get => _Current_Mana;
            set
            {
                if (value < 0)
                    _Current_Mana = 0;
                else
                    if (value > Max_Mana)
                    _Current_Mana = Max_Mana;
                else
                    _Current_Mana = value;
            }
        }

        public Cleric() : base(50, "Safin")
        {
            _Current_Mana = 60;
            Max_Mana = _Current_Mana;
        }

        public void CureSomebody(Unit unit)
        {
            if (unit.Alive)
            {
                if (unit.Health == MaxHealth)
                    Console.WriteLine($"{Name} is completely healthy");
                else
                {
                    while (Mana > 0 && unit.Health < unit.MaxHealth)
                    {
                        unit.Health += 1;
                        Mana -= 2;
                    }
                }
            }
            else
                Console.WriteLine($"You can't cure {unit.Name}, because he died");

        }

        public void CureYourself(Unit cleric)
        {
            if (cleric.Alive)
            {
                if (cleric.Health == cleric.MaxHealth)
                    Console.WriteLine($"You are completely healthy");
                else
                {
                    while (Mana > 0 && cleric.Health < cleric.MaxHealth)
                    {
                        cleric.Health += 2;
                        Mana -= 1;
                    }
                }
            }
            else
                Console.WriteLine($"You can't cure yourself, because you died");
        }

        public void RegenerationMana()
        {
            Mana += 10;
            Console.WriteLine($"You have restored Mana. Now, your Mana: {Mana}");
        }

        public void ShowInfo()
        {
            if (Alive)
                Console.WriteLine($"Unit: {Name} Health: {Health} Mana: {Mana}");
            else
                Console.WriteLine($"{Name} is dead");
        }
    }
}
