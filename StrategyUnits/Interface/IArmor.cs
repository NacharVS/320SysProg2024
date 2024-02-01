using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interface
{
    internal interface IArmor //ЗАЩИТА
    {
        public int Armor { get; set; } //Защита
        public static int LevelArmor { get; set; } //Уровень защиты
    }
}
