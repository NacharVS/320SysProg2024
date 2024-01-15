using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _minDamage;
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        private int _maxDamage;

        public MilitaryUnit(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage) : base(currentHealth, nameOfClass, defense)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public virtual void Attack(Unit attackedUnit)
        {
            Console.WriteLine("Unit was attacked with the damage of 0.");
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {this.NameOfClass} Health: {this.CurrentHealth} MaxHealth: {this.MaxHealth} \nDefense: {this.Defense} MinDamage: {this.MinDamage} MaxDamage: {this.MaxDamage}");
        }

    }
}
