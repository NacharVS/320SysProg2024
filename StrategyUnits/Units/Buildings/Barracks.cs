using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units.Buildings
{
    internal class Barracks : ICommonInformation
    {
        public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Barracks()
        {
            
        }

        public Footman CreateFootman(string nameOfUnit)
        {
            Footman footman =  new Footman(60, "Рекрут", 2, 5, 20, 50, nameOfUnit, 1, 1);
            footman.HealthDecreasedEvent += HealthDecreased;
            footman.HealthIncreasedEvent += HealthIncreased;
            return footman;
        }
        public Footman CreateBersekr(string nameOfUnit)
        {
           Berserk berserk = new Berserk(100, "Берсерк", 2, 5, 20, 200, nameOfUnit, 1, 1);
            berserk.HealthDecreasedEvent += HealthDecreased;
            berserk.HealthIncreasedEvent += HealthIncreased;
            return berserk;
        }

   

        public void ShowInformation()
        {
            Console.WriteLine($" Персонаж: {Name}\n");
        }


        static void HealthDecreased(int previousHealth, int currentHealth, int maxHealth)
        {
            Console.WriteLine(
                $"Здоровье было снижено на {previousHealth - currentHealth} HP\n" +
                $"Текущее здоровье: {currentHealth}/{maxHealth}\n");
        }

        static void HealthIncreased(int previousHealth, int currentHealth, int maxHealth)
        {
            Console.WriteLine( 
                $"Здоровье было повышено {currentHealth - previousHealth} HP\n" +
                $"Текущее здоровье: {currentHealth}/{maxHealth}\n");

        }


    }
}
