﻿using System.Reflection.Metadata.Ecma335;

namespace StrategyUnits
{
    internal class Unit
    {
        public delegate void HealthchangedDelegate(string name, int oldHealth, int newHealth, int maxHealth);

        private string? _name;
        private int _health;
        private int _maxHealth;
        private bool _alive;

        public Unit(string? name, int maxHealth)
        {
            _name = name;
            _maxHealth = maxHealth;
            _health = _maxHealth;
            _alive = true;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
        }

        public int Health 
        { 
            get => _health;
            set
            {
                if (!Alive)
                {
                    return;
                }
                if (value > Health)
                {
                    HealthIncreasedEvent.Invoke(Name, Health, value, MaxHealth);
                }
                else
                {
                    HealthDecreasedEvent.Invoke(Name, Health, value, MaxHealth);
                }
                if (value <= 0)
                {
                    _health = 0;
                    _alive = false;
                    Console.WriteLine($"{Name} умер");
                }
                else if (value > _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
                if (this is Berserker b)
                {
                    if (Health < MaxHealth / 2 && !b._rageActive)
                    {
                        b._rageActive = true;
                        Console.WriteLine($"Здоровье {Name} стало меньше половины. Урон увеличился и стал {b.MinDamage}-{b.MaxDamage}");
                    }
                    if (Health >= MaxHealth / 2 && b._rageActive)
                    {
                        b._rageActive = false;
                        Console.WriteLine($"Здоровье {Name} дошло до половины или больше. Урон стал обычным {b.MinDamage}-{b.MaxDamage}");
                    }
                }
            }
        }

        public int MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }

        public void Move()
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может передвигаться");
                return;
            }
            Console.WriteLine($"{Name} движется");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Здоровье: {Health}/{MaxHealth}");
        }

        public static event HealthchangedDelegate? HealthIncreasedEvent;
        public static event HealthchangedDelegate? HealthDecreasedEvent;
    }
}
