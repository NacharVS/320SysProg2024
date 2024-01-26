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
        public Unit(int health)
        {
            IsAlive = true;
            Health = health;
            MaxHealth = Health;
        }
        public int Health { get; set; }

        public int MaxHealth { get; set; }

        public bool IsAlive { get; set; }

        public virtual void TakeDamage(int damage)
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
