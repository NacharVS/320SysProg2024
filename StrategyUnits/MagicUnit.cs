using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _manaPoints;
        private int _maxManaPoints;

        public int MaxManaPoints
        {
            get { return _maxManaPoints; }
            set { _maxManaPoints = value; }
        }


        public MagicUnit(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage)
        {
            ManaPoints = manaPoints;
            MaxManaPoints = manaPoints;
        }

        public int ManaPoints
        {
            get { return _manaPoints; }
            set { _manaPoints = value; }
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {this.NameOfClass} Health: {this.CurrentHealth} MaxHealth: {this.MaxHealth} \nDefense: {this.Defense} MinDamage: {this.MinDamage} MaxDamage: {this.MaxDamage} \nManaPoints: {this.ManaPoints}");
        }

        public virtual void AttackMagically(Unit unit)
        {

        }
    }
}
