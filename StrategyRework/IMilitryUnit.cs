using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyRework
{
    internal interface IMilitryUnit : IWarrior
    {
        public int Damage { get; set; }
        public int MaxDamage { get; set; }
        public int LvlUpDamage { get; set; }
        public void Attack(IUnit unit);
    }
}
