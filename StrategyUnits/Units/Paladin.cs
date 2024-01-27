using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class Paladin : ZealotKnight, IMagicAttack
    {
        private bool _holyArmorActive = false;
        private double _magicDamage;

        public Paladin(string? name, bool isDied, double currentHealth, double maxHealth, int energy, int maxEnergy, int protection, double magicDamage) : base(name, isDied, currentHealth, maxHealth, energy, maxEnergy, protection)
        {
            _magicDamage = magicDamage;
        }

        public double MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }

        public void MagicAttack(IHealth unit)
        {
            DecreaseEnergy(2);
            unit.DecreaseHealth(10);
        }

    }
}
