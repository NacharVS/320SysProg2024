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

        public Paladin(int magicDamage) : base(15, "Paladin", 10, 15)
        {
            _magicDamage = magicDamage;
        }

        public void MagicAttack(Unit unit)
        {
            if (this.CurrentEnergy > 0)
            {
                unit.CurrentHealth -= _magicDamage;
                CurrentEnergy -= 1;
            }
        }

        public void Attack(Unit unit)
        {
            unit.CurrentHealth -= Damage;
        }
    }
}
