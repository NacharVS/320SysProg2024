using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class MilitaryUnit : Unit, IMilitaryUnit, IAttackedUnit
    {
        private int _minDamage;
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        private int _maxDamage;

        private int _armorlevel = 1;

        public int Armorlevel
        {
            get { return _armorlevel; }
            set { _armorlevel = value; }
        }


        private int _weaponlevel = 1;

        public int WeaponLevel
        {
            get { return _weaponlevel; }
            set { _weaponlevel = value; }
        }

        public MilitaryUnit(int currentHealth, string? nameOfClass, int defense, int ArmorLevel, int WeaponLevel, int minDamage, int maxDamage) : base(currentHealth, nameOfClass, defense)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        double IMilitaryUnit.MinDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IMilitaryUnit.MaxDamage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Attack(Unit attackedUnit)
        {
            Random rnd = new Random();
            int appliedDamage = rnd.Next(MinDamage, MaxDamage) - attackedUnit.Defense;
            if (!attackedUnit.IsDead)
            {
                if (appliedDamage >= 0)
                {
                    Console.WriteLine(
                        $" Атака была успешна проведена. Вы нанесли {appliedDamage} ({appliedDamage + attackedUnit.Defense}-{attackedUnit.Defense}) DP.\n"
                        );
                    attackedUnit.CurrentHealth -= appliedDamage;
                }
                else
                {
                    Console.WriteLine(" Атака была провалена!! \n");
                }
            }
            else
            {
                Console.WriteLine("Юнита больше нет в живых. Остановитесь!\n");
            }

        }

        public void ShowInformation()
        {

            Console.WriteLine($"Юнит: {NameOfClass} \nЗдоровье: {CurrentHealth} Максимальное здоровье: {MaxHealth} \n" +
                $"Броня: {Defense} Минимальный урон: {MinDamage} Максимальный урон: {MaxDamage}");
        }

        public void Attack(IAttackedUnit unit)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public void GetHeal(int heal)
        {
            throw new NotImplementedException();
        }

        public void InflictkDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }
}

