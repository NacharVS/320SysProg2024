using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZealotKnight : MagicUnit
    {
        public string? _Name;
        public int _damage;
        public int _health;
        public int _mana;
        public ZealotKnight(string? name, int damage, int health, int mana) : base(damage, name, health, mana)
        {
            _Name = name;
            _damage = damage;
            _health = health;
            _mana = mana;
        }
        public void Pray()
        {
            
            if (Dead)
            { Console.WriteLine("He can't Pray, because he's dead("); }
            else 
            { 
                if (Mana < 10)
                {
                    Console.WriteLine("No enough mana");
                }
                else 
                { 
                    if (Health >= MaxHealth)
                    {
                        Console.WriteLine("He is healthy. So he doesn't need Prayer");
                    }
                    else 
                    { 
                        Console.WriteLine("Is praying....");
                        Mana -= 10;
                        Health += 20;
                        Console.WriteLine($"Current mana: {Mana} | Current Health: {Health}");
                    }
                }
            }
            
            
        }
    }
}
