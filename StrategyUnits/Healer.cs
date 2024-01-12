
using System.Runtime.CompilerServices;

namespace StrategyUnits
{
    internal class Healer : Unit
    {
        private int _manaPoints;

        public int ManaPoints
        {
            get { return _manaPoints; }
            set { _manaPoints = value; }
        }

        public Healer(int manaValue) : base(50, "Healer")
        {
            ManaPoints = manaValue;
        }

        public void HealSomebody(Unit unit)
        {
            if (unit.IsDead == true)
            {
                Console.WriteLine("Unit is dead.");
                return;
            }
            while (_manaPoints > 0)
            {
                if(unit.CurentHealth < unit.MaxHealth)
                {
                    _manaPoints -= 2;
                    Console.WriteLine($"Healed from {unit.CurentHealth} to {unit.CurentHealth+1}; Mana left: {_manaPoints}");
                    unit.CurentHealth++;
                }
                if (unit.CurentHealth >= unit.MaxHealth)
                {
                    Console.WriteLine($"Healed successfully.");
                    break;
                }
                    
            }
            if (ManaPoints == 0)
            {
                Console.WriteLine("No mana left!");
            }   
        }

        public void Healself()
        {
            if (IsDead == true)
            {
                Console.WriteLine("Unit is dead.");
                return;
            }
            while (_manaPoints > 0)
            {
                if (CurentHealth < MaxHealth)
                {
                    _manaPoints--;
                    int finalHealth = CurentHealth + 2 >= MaxHealth ? MaxHealth : CurentHealth+2;
                    Console.WriteLine($"Healed from {CurentHealth} to {finalHealth}; Mana left: {_manaPoints}");
                    CurentHealth += 2;
                }
                if (CurentHealth >= MaxHealth)
                {
                    Console.WriteLine($"Healed successfully.");
                    break;
                }
            }
            if (ManaPoints == 0)
            {
                Console.WriteLine("No mana left!");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {CurentHealth} MaxHealth: {MaxHealth} Mana: {ManaPoints}");
        }
    }
}
