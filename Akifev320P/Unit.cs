using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Akifev320P
{
    internal class Unit
    {


        public delegate void HealthChangedDelegate(string name, int health, int currentHealth);

        private int _health;
        private string _name;
        public bool isAlive { get; private set; }
        public int MaxHealth { get; private set; }

        public Unit() { }
        public Unit(int health, string name)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            isAlive = true;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;

        public int Health
        {
            get => _health; set
            {
                if (value > Health)
                {
                    Console.WriteLine("erwr");
                   HealthIncreasedEvent .Invoke(Name, Health, value);
                }
                else
                {
                    HealthDecreasedEvent.Invoke(Name, Health, value);
                }
                if(value == Health)
                {
                    Console.WriteLine("0 damage");
                }
                if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    if (value > MaxHealth) _health = MaxHealth;
                    else _health = value;
                }
            }
        }

    




        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }


    }
}
