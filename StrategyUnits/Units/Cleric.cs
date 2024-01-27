using StrategyUnits.Inerfaces;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class Cleric : Unit, IMagicAbilities, IHealer, IMagicAttack
    {

        public Cleric(string? name, bool isDied, double currentHealth, double maxHealth, int energy, int maxEnergy, double magicDamage) : base(name, isDied, currentHealth, maxHealth)
        {
            Energy = energy;
            MaxEnergy = maxEnergy;
            MagicDamage = magicDamage;
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
                if (unit.MaxHealth <= unit.CurrentHealth)
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
