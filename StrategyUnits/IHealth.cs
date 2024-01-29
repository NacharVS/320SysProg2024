using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IHealth //ЗДОРОВЬЕ
    {
        public int Health { get; set; }  //Здоровье
        public int MaxHealth { get; set; }  //Максимальное Здоровье
        public bool IsDead { get; set; }  //Статус жизни
        public void DecreaseHealth(int damage);  //Уменьшение Здоровья
        public void IncreseHealth(int health);  //Увеличение здоровья


        //Делегат и ивент
        public delegate void HealthChangeDelegate(int _health, string? name, int change, int maxHealth);  
        public event HealthChangeDelegate HealthDecreasedEvent;  //Уменьшение
        public event HealthChangeDelegate HealthIncreasedEvent;  // Увеличение
    }
}
