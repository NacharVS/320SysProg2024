using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units.Buildings
{
    internal class Altar : ICommonInformation
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

        public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public Healer CreateHealer(string nameOfUnit)
        {
            return new Healer(60, "Лекарь", 2, 7, 9, 70, 1, 1);

        }
        public ZealotKnight CreateZealotKnight(string nameOfUnit)
        {
            return new ZealotKnight(90, "Святой рыцарь", 2, 5, 20, 100, 1, 1);

        }

        public Paladin CreatePaladin(string nameOfUnit)
        {
            return new Paladin(80, "Палладин", 2, 11, 13, 85, 1, 1);

        }

        public void ShowInformation()
        {
            Console.WriteLine($"{AltarName} - Алтарь \n" +
               $"У алтаря осталось {Capacity} EP\n");
        }
    }
}
