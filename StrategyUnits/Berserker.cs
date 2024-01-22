using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        private bool _rage;
        public bool Rage
        {
            get { return _rage; }
            set { _rage = value; }
        }
        public Berserker(string? name, int maxHP, int protection, int damage) : base(name, maxHP, protection, damage) { }

        public void ActivateRage(Unit unit)
        {
            if (CurrentHP > MaximumHP / 2)
            {
                _rage = true;
                Damage += Damage / 2;
                Console.WriteLine($"{Name} activated rage.");
            }
            else
            {
                _rage = false;
                Damage = Damage;
                Console.WriteLine();
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name} Current health: {CurrentHP}/{MaximumHP} Damage: {Damage} Protection: {Protection}/{MaximumProtect} Weapon Level: {WeaponLvl} Armor Level : {ArmorLvl}");
        }
    }
}
