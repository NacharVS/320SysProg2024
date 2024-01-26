﻿namespace StrategyUnits
{
    internal class Unit : IHealth
    {
        public string Name;
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public Unit (string name, int health, int maxHealth)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        //private string? _name;
        //private int _currentHP;
        //private bool _deadUnit;
        //private int _weaponLvl;
        //private int _protection;
        //private int _armorLvl;

        //public int MaximumHP { get; private set; }
        //public int MaximumProtect { get; private set; }

        //public Unit(string? name, int maxHP, int maxProtect)
        //{
        //    _name = name;
        //    MaximumProtect = maxProtect;
        //    MaximumHP = maxHP;
        //    _protection = MaximumProtect;
        //    _currentHP = MaximumHP;
        //    _deadUnit = false;
        //}
        //public int WeaponLvl
        //{
        //    get { return _weaponLvl; }
        //    set { _weaponLvl = value; }
        //}
        //public int ArmorLvl
        //{
        //    get { return _armorLvl; }
        //    set { _armorLvl = value; }
        //}
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        //public int Protection
        //{
        //    get => _protection;
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _protection = 0;
        //        }
        //        else
        //        {
        //            if (value > MaximumProtect)
        //            {
        //                _protection = MaximumProtect;
        //            }
        //            else
        //            {
        //                _protection = value;
        //            }
        //        }
        //    }
        //}
        //public int CurrentHP
        //{ 
        //    get => _currentHP; 
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            _currentHP = 0;
        //            _deadUnit = true;
        //            Console.WriteLine($"{this.Name} мертв.\n");
        //        }
        //        else
        //        {
        //            if (value > MaximumHP)
        //            {
        //                _currentHP = MaximumHP;
        //                Console.WriteLine($"{this.Name} имеет максимальное HP.\n");;
        //            }
        //            else
        //            {
        //                _currentHP = value;
        //            }
        //        }
        //    }
        //}
        //public bool DeadUnit
        //{
        //    get { return _deadUnit; }
        //    set { _deadUnit = value; }
        //}

        //public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public int MaxHealth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public void Move()
        //{
        //    Console.WriteLine("Is moving");
        //}

        //public virtual void ShowInfo()
        //{
        //    Console.WriteLine($"Unit: {_name} Health: {_currentHP}/{MaximumHP} Protection {_protection} Unit is dead: {DeadUnit} Weapon Level {_weaponLvl} Armor Level {_armorLvl}\n");
        //}

        //public void TakeDamage(int damage)
        //{
        //    Health -= damage;
        //}

        //public delegate void HPChangeDelegate(int maxHP, string name);

        //public event HPChangeDelegate HealthDecreasedEvent;
        //public event HPChangeDelegate HealthIncreasedEvent;
        //public event HPChangeDelegate HealthChangedEvent;
    }
}