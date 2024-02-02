using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{

    internal class MagicUnit : MilitaryUnit, IMagicUnit
    {
        private int _manaPoints;
        private int _maxManaPoints;

        public event IMagical.EnergyChangedDelegate EnergyDecreasedEvent;
        public event IMagical.EnergyChangedDelegate EnergyIncreasedEvent;

        public int MaxManaPoints
        {
            get { return _maxManaPoints; }
            set { _maxManaPoints = value; }
        }


        public MagicUnit(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints, int ArmorLevel, int WeaponLevel) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, ArmorLevel, WeaponLevel)
        {
            ManaPoints = manaPoints;
            MaxManaPoints = manaPoints;
        }

        public int ManaPoints
        {
            get { return _manaPoints; }
            set { _manaPoints = value; }
        }


        public  virtual void MagicAttack(IAttackedUnit unit)
        {
            Random random = new Random();
            int appliedDamage = random.Next(MinDamage, MaxDamage) - unit.Defense;
            if (!IsDead)
            {
                if (appliedDamage >= 0)
                {
                    Console.WriteLine($"Вы нанесли {appliedDamage} ({appliedDamage + Defense}-{Defense}) урона. Вы потеряли {appliedDamage * 2} маны\n");
                    InflictkDamage(appliedDamage);
                    IncreaseEnergy(appliedDamage * 2);

                }
                else
                {
                    Console.WriteLine("Атака была провалена!");
                }
            }
        }


        public void IncreaseEnergy(int manaPoints)
        {
           ManaPoints += manaPoints;
        }

        public void DecreaseEnergy(int manaPoints)
        {
            ManaPoints -= manaPoints;
        }
    }
}
