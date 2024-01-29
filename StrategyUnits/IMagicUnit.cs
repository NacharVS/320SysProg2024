using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicUnit
    {
        public int Manna { get; set; } //Манна
        public int MaxManna { get; set; } //Максимальная манна
        public void DecreaseManna(int manna); //- Манна
        public void IncreaseManna(int manna); //+ Манна

        //Делегаты и ивенты изменеия манны
        public delegate void MannaChangedDelegate(string? name, int change_manna, int manna, int maxManna);

        public event MannaChangedDelegate MannaDecreasedEvent; //-
        public event MannaChangedDelegate MannaIncreasedEvent; //+
    }
}
