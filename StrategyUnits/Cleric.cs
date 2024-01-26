using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : Unit, IMagicAbilities, IHealer
    {
        
        public Cleric(string? name, double health, double damage, double defence, double maxEnergy) : base(name, health, damage, defence, maxEnergy)
        {
           
        }

        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public double MagicDamage { get; set; }

        public void DecreaseEnergy(int energy)
        {
            Energy -= 2;
        }

        public void HealSomebody(IHealth unit)
        {
            if (IsDied)
            {
                return;
            }
            while (Energy > 0)
            {
                if (MaxHealth <= Health)
                {
                    return;
                }
                if (Energy < 2)
                {
                    break;
                }
                unit.IncreseHealth(1);
                DecreaseEnergy(2);
            }
        }

        public void IncreaseEnergy(int energy)
        {
            Energy += energy;
        }

        public void MagicAttack(IHealth unit)
        {
            DecreaseEnergy(1);
            unit.DecreaseHealth(4);
        }
    }
}
