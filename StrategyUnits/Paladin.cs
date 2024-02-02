using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight, IPaladin
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
        public override int Health
        {
            get => base.Health;
            set
            {
                base.Health = value;
                double percent = Math.Round(((double)PrevHealth / (double)_maxHealth), 4);
                if (Rrage && (percent >= 0.5) && Suit)
                {
                    Console.Write("HolyArmor's ON | Previous suit HP: " + SuitHP);
                    SuitHP *= 2;
                    Console.WriteLine("| Current suitHP: " + SuitHP);
                }
            }
        }
    }
}