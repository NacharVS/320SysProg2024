using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnitsOnInterfaces
{
    internal class Unit
    {
        
        public virtual int Health { get; set; }

        public int MaxHealth { get; set; }
        public bool IsAlive { get; set; }
        public int Gold { get; set; }
        public int MaxGold { get; set; }
        public Unit(int health)
        {
            IsAlive = true;
            Health = health;
            MaxHealth = Health;
            Gold = 30;
            MaxGold = Gold;
        }

        public virtual async void TakeDamage(int damage)
        {
            if (!IsAlive)
            {
                Console.WriteLine("Unit is death");
                return;
            }
                
            Health -= damage;

            if (Health < 0)
            {
                IsAlive = false;
                Health = 0;
            }
            StartGoldRecovery();
        }
        public async Task StartGoldRecovery()
        {
            await Task.Run(async () =>
            {
                if (Gold == 0)
                {
                    Console.WriteLine($"Золото отсутствует. Начинаем восстановление...");
                    Gold += 1;
                    Console.WriteLine($"Золото восстановлено. Текущее количество золота: {Gold}");
                    await Task.Delay(10000);
                }
            });
        }
        

        public void Move()
        {
            Console.WriteLine("Unit is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}");
        }
    }
}
