using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        private string _altarName;

        public string AltarName
        {
            get { return _altarName; }
            set { _altarName = value; }
        }

        private int _capability;

        public int Capacity
        {
            get { return _capability; }
            set { _capability = value; }
        }

        public Altar(string altarName)
        {
            AltarName = altarName;
            Capacity = 5000;
        }

        public void RestoreMana(MagicUnit restorableUnit)
        {
            if (restorableUnit.MaxManaPoints != restorableUnit.ManaPoints)
            {
                int manaDifference = restorableUnit.MaxManaPoints - restorableUnit.ManaPoints;
                restorableUnit.ManaPoints += manaDifference;
                Capacity -= manaDifference * 5;
                Console.WriteLine($" Алтарь восстанавливает {manaDifference} MP, теряет {manaDifference * 5} EP из алтаря\n");
            }
        }

        public void ShowInfo()
        {

            Console.WriteLine($"{AltarName} - Алтарь \n" +
                $"У алтаря осталось {Capacity} EP\n");
        }

    }
}
