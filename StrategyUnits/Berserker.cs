using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Extra;

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
        public Berserker(string? name, int maxHP, int maxProtect, int damage) : base(name, maxHP, maxProtect, damage) { }

        public void ActivateRage()
        {
            if (CurrentHP < MaximumHP / 2)
            {
                _rage = true;
                Damage += Damage / 2;
                Console.WriteLine($"{Name} активировал ярость.");
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
            Console.WriteLine($"Unit: {Name} Current health: {CurrentHP}/{MaximumHP} Damage: {Damage} Protection: {Protection}/{MaximumProtect} Weapon Level: {WeaponLvl} Armor Level : {ArmorLvl}\n");
        }
    }
}
