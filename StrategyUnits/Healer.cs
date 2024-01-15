using System.Xml.Linq;

namespace StrategyUnits
{
    
    internal class Healer : MagicUnit
    {

      
        public Healer() : base(50, "Healer", 3, 60)
        {
 
        }

        public void HealSomebody(Unit unit)
        {
            while(Mana > 0 || MaxHealth - Health > 0)
            {
                Health += 1;
                Mana -= 2;
            }
        }

        public void HealSelf (Unit unit)
        {
            while (Mana > 0 || MaxHealth - Health > 0)
            {
                Health += 2;
                Mana -= 1;
            }
        }
    }
}
