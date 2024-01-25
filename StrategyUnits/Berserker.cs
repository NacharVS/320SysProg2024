using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        internal bool _rage = false;
        public Berserker(int health, string name, int damage, int armor) : base(health, name, damage, armor)
        {
        }
        public int RageDamag
        {
            get
            {
                if (_rage)
                {

                    return Damage + Damage;
                }
                else
                {
                    return Damage;
                }
            }
            set
            {
                Damage = value;
            }
        }


    }
}
