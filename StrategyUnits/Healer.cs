using System.Xml.Linq;

namespace StrategyUnits
{

    internal class Healer : MagicUnit
    {
        public Healer(int health, string name, int damage, int maxMana, int armor) : base(health, name, damage, maxMana, armor)
        {
        }

        public void HealSomebody(Unit unit)
        {
            while (Mana > 0 && unit.MaxHealth - unit.Health > 0)
            {
                unit.Health += 1;
                Mana -= 2;
            }
        }

        public void HealSelf(Unit unit)
        {
            while (Mana > 0 && MaxHealth - Health > 0)
            {
                Health += 2;
                Mana -= 1;
            }
        }
    }
}