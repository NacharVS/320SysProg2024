using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class ZealotKnight : Unit, IMagicAbilities, IArmoredUnit
    {
  

        
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public int Protection { get; set; }
        public ZealotKnight(string? name, bool isDied, double currentHealth, double maxHealth, int energy, int maxEnergy, int protection) : base(name, isDied, currentHealth, maxHealth)
        {
            Energy = energy;
            MaxEnergy = maxEnergy;
            Protection = protection;
        }
        public void DecreaseEnergy(int energy)
        {
            Energy -= 2;
        }

        public void IncreaseEnergy(int energy)
        {
            Energy += energy;
        }
        public void Player()
        {
            if (Energy >= 10)
            {
                Energy -= 10;
                CurrentHealth += 20;
            }
            else
            {
                Console.WriteLine("Недостаточно очков энергии для восстановления здоровья");
            }

            if (IsDied == true)
            {
                Console.WriteLine($"Персонаж {Name} мертв, действие невозможно");
            }
        }
    }
}
