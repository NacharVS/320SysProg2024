using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private int _magicDamage;
        public int MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }

        public Paladin() : base(15, "Paladin", 10, 15)
        {
            _magicDamage = 10;
        }

        public void MagicAttack(Unit unit)
        {
            if (this.CurrentEnergy > 0)
            {
                unit.CurrentHealth -= _magicDamage;
                CurrentEnergy -= 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{this.Name} not enough energy. Current energy {this.CurrentEnergy}");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        public void Attack(Unit unit)
        {
            unit.CurrentHealth -= Damage;
        }
    }
}
