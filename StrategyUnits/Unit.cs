﻿namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string? _name;
        public bool? IsDead { get; private set; }
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            MaxHealth = _health;
            IsDead = false;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                {
                    _health = 0;
                    IsDead = true;
                    Console.WriteLine("Character is dead.Stop damage.");
                }
                else
                   if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health} Мервт: {IsDead}");
        }
    }
}