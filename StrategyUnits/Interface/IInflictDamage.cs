using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interface
{
    internal interface IInflictDamage
    {
        public int Damage { get; set; } //Урон
        public void InflictDamage(IHealth health); //Метод нанесения урона
        public static int LevelWeapon { get; set; } //Уровень урона
    }
}
