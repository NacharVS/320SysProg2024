using StrategyUnits.Inerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class Barrack : IGeneralInformation// factory class
    {
        public Barrack(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }

        //Soldiers
        public Footman CreateRecruit()
        {
            return new Footman("Рекрут", false, 10, 10, 7);
        }
        public Footman CreateFootman()
        {
            return new Footman("Рыцарь", false, 14, 14, 9);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker("Берсерк", false, 20, 20, 12, 10);
        }
        public void ShowInformation()
        {
            Console.WriteLine($" Персонаж: {Name}\n");
        }
    }
}
