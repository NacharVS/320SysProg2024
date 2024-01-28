using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker: Footman, IArmor 
    {

        public Berserker(int change_health, int maxHealth, string? name, bool deadperson, int damage, int guard) : base(change_health, name, deadperson, change_health, maxHealth, damage) 
        {
            _guard = guard;
        }

        private int _guard;

        public int Guard
        {
            get => IArmor.LevelArmor * 2 + _guard;
            set => IArmor.LevelArmor = value;
        }
        public void Rage(IHealth unit)
        {
            if (DeadPerson)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unit died.");
                Console.ResetColor();
                return;
            }
            if (Change_Health < (MaxHealth / 2))
            {
                Damage += Damage / 2;
                Console.WriteLine($"{Name} has less than half health: {Change_Health}/{MaxHealth}\n Damage: {Damage}");
            }
            else
            {
                Console.WriteLine("");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name} \n Health: {Change_Health}/{MaxHealth}\n Damage: {Damage}\n Guard: {Guard} \n Live? {!DeadPerson}");
        }

    }
}
