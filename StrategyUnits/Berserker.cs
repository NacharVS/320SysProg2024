﻿namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public Berserker(int health, string? name, int armor, int damage) : base (health, name, armor, damage)
        {

        }

        public void Rage (Unit unit) //Ярость
        {
            if (Health > (Health * 0.5))
            {
                Damage = (int)(Damage + (Damage * 0.5));
                unit.Health -= Damage;
                Console.WriteLine($"{unit.Name} получил урон {Damage}");
            }
        }
    }
}
