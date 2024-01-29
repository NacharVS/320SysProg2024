using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicAttack //Создается Магическая Атака, т.к., не все магические юниты атакуют магией
    {
        public int MagicDamage { get; set; }
        public void MagicAttack(IHealth unit);

    }
}
