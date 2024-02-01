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
            Task task = StartGoldRecovery();
            await task;
        }
        public async Task StartGoldRecovery()
        {
            await Task.Run(async () =>
            {
                    Console.WriteLine($"Золото отсутствует. Начинаем восстановление...");
                    RecoverGold();
                    Console.WriteLine($"Золото восстановлено. Текущее количество золота: {Gold}");
                    await Task.Delay(10000);
            });
        }


        private void RecoverGold()
        {
            Gold += 1; 
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
