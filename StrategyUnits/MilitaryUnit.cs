﻿using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        public delegate void InflictDamageDelegate(int damage, int health, string nameDealtDamage, string nameReceivedDamage); //Делегат НанесенияУрона -- ПолучилУрон, НанесУрон
        //Урон
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        //Метод нанесения урона
        public void InflictDamage(Unit unit)
        {
            if (IsDead == true)
                Console.WriteLine($"{Name} мёртв.");
            else if (unit.IsDead == true)
                Console.WriteLine($"{unit.Name} мёртв.");
            else
            {
                if (unit.Armor > 0 )
                {
                    if (_damage >= unit.MaxArmor)
                    {
                        unit.Armor = 0;
                        unit.Health -= (_damage - unit.MaxArmor);
                    }

                }
                else
                {
                    unit.Health -= _damage;
                }
                InflictDamageEvent.Invoke(_damage, unit.Health, Name, unit.Name); //При нанесении урона вызывается событие
            }
        }

        public MilitaryUnit(int health, string? name, int armor, int damage) : base(health, name, armor)
        {
            _damage = damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name}\t Здоровье: {Health} Защита: {Armor} Атака: {Damage} Состоние жизни: {IsDead}");
        }

        public event InflictDamageDelegate InflictDamageEvent; //Ивет НанесенияУрона
    }
}
