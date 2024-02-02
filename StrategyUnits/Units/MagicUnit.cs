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


      

        public virtual void AttackMagically(Unit unit)
        {

        }

        public void MagicAttack(IAttackedUnit unit)
        {
            throw new NotImplementedException();
        }

        public void TakeMana(int manaPoints)
        {
            throw new NotImplementedException();
        }

        public void IncreaseEnergy(int manaPoints)
        {
            throw new NotImplementedException();
        }

        public void DecreaseEnergy(int manaPoints)
        {
            throw new NotImplementedException();
        }
    }
}
