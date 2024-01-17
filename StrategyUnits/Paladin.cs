using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private int ManaCast;
        public HealthChangedDelegate MagicFireBollAttack;
        public Paladin() : base(90, "Paladin", true, 5, 15, 45)
        {
            ManaCast = 3;
        }
        public override int Mana
        {
            get => base.Mana;
            set => base.Mana = value;
        }

        public override void Attack(Unit unit)
        {
            Random random = new Random();
            Damage = random.Next(_damage, MaxDamage);
            unit.Health -= Damage;
            Mana -= ManaCast;
            if (unit.Health == 0)
            {
                unit._active = false;
            }
            MagicFireBollAttack.Invoke(unit.Health,unit.Name,Damage,ManaCast);
        }
    }
}
