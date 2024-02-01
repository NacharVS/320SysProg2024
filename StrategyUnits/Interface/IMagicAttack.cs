using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interface
{
    internal interface IMagicAttack //Создается Магическая Атака, т.к., не все магические юниты атакуют магией
    {
        public int MagicDamage { get; set; } //Магический урон
        public void MagicAttack(IHealth unit); //Метод нанесения магического

    }
}
