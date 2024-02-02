using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsOnInterfaces
{
    internal class Footman : Unit, IBattleUnit
    {
        public Footman(int health, int minDamage, int maxDamage, int protection) : base(health)
        {
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Protection = protection;
        }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Protection { get; set; }
        public int LevelArmor { get; set; }
        public int LevelWeapon { get; set; }

        public void Attack(Unit unit)
        {
            Random rnd = new Random();
            unit.Gold -= 5;
            Gold += 5;
            unit.TakeDamage(rnd.Next(MinDamage, MaxDamage));
        }

        public override void TakeDamage(int damage)
        {
            if (!IsAlive)
            {
                Console.WriteLine("Unit is death");
                return;
            }

            else if (damage > Protection)
                Health -= damage - Protection;

            if (Health < 0)
            {
                IsAlive = false;
                Health = 0;
            }
        }
    }
}