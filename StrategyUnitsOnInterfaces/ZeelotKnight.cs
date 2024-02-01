﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnitsOnInterfaces
{
    internal class ZeelotKnight : Unit, IMagicUnit, IBattleUnit, IHolyUnit
    {
        public ZeelotKnight(int health, uint mana) : base(health)
        {
            Mana = mana;
            MaxMana = Mana;
        }

        public uint Mana { get; set; }
        
        public uint MaxMana { get; set; }
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
        public void Pray()
        {
            if (Health == MaxHealth)
            {
                Console.WriteLine($"ZeelotKnight's health is full");
                return;
            }
            else if (!IsAlive)
            {
                Console.WriteLine($"ZeelotKnights is dead");
                return;
            }
            if (Mana < 10)
            {
                Console.WriteLine($"MP is not enough");
                return;
            }
            Console.WriteLine("\"Pray\" use. HP was added");
            Mana -= 10;
            Health += 20;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: ZeelotKnight Health: {Health} Manna: {Mana}");
        }
    }
}
