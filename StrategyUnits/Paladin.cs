using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight
    {
        public Paladin() : base("Paladin", 11, 50, 50)
        {
            maxMana = _mana;
        }
        public void HollyFire(Unit unit)
        {
            Console.WriteLine("Holy Fire");
            unit.PrevHealth = unit.Health;
            if (unit.Suit)
            {
                unit.SuitHP -= _damage*2;
                Mana -= 7;
                if (SuitHP <= 0)
                {
                    unit.SuitHP -= _damage*2;
                    unit.Health += unit.SuitHP;
                    Console.Write("Suit is broken");
                    Console.Write(" | Attack was " + unit.SuitHP);
                    Console.WriteLine(" | Current Health: " + unit.Health);
                    unit.Suit = false;
                }
            }
            else
                unit.Health -= _damage * 2;
            Console.WriteLine(Name + "'s current mana: " + Mana);
        }
    }
}