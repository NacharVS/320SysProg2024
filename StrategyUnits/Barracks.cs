using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracks : ICreating
    {
        private int _damage;
        
        public Footman CreateRecruit()
        {
            return new Footman(60, "Recruit", 10);
        }
        public Footman CreateFootman()
        {
            return new Footman(90, "Footman", 12);
        }
        public Footman CreateBerserker()
        {
            return new Footman(120, "Berserker", 15);
        }
        public Healer CreateHealer(string nameOfUnit)
        {
            Healer healer = new Healer();
            return healer;
        }
        public Paladin CreatePaladin(string nameOfUnit)
        {
            return new Paladin(); 
        }
    }
}