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
        public MagicUnit(int currentHealth, string? nameOfClass, int defense) : base(currentHealth, nameOfClass, defense)
        {
            ManaPoints = _manaPoints;
            MaxManaPoints = _manaPoints;
        }
        public int ManaPoints
        {
            get { return _manaPoints; }
            set { _manaPoints = value; }
        }


        public override void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Unit: {NameOfClass} Health: {CurrentHealth} MaxHealth: {MaxHealth} \nDefense: {Defense} MinDamage: {MinDamage} MaxDamage: {MaxDamage} \nManaPoints: {ManaPoints}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public virtual void AttackMagically(Unit unit)
        {

        }
    }
}
