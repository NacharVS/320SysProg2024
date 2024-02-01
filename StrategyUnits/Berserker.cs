using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker: Footman, IArmor, ISwitchs
    {
        public bool Switchs { get; set; }
        public Berserker(int change_health, int maxHealth, string? name, bool deadperson, int damage, int guard) : base(change_health, name, deadperson, change_health, maxHealth, damage) 
        {
            _guard = guard;
            Switchs = false;
        }

        private int _guard;

        public int Guard
        {
            get => IArmor.LevelArmor * 2 + _guard;
            set => IArmor.LevelArmor = value;
        }
        public bool Switch { get; set; }

        //public override int Change_Health
        //{
        //    get => base.Change_Health;
        //    set
        //    {
        //        int beginHealth = base.Change_Health;
        //        if (value <= 0)
        //        {
        //            base.Change_Health = 0;
        //            DeadPerson = true;
        //        }
        //        else
        //        {
        //            if (value > MaxHealth)
        //                base.Change_Health = MaxHealth;
        //            else
        //                base.Change_Health = value;
        //        }

        //        if (base.Change_Health < MaxHealth * 0.5 && !Switchs && !DeadPerson)
        //        {
        //            Switchs = true;
        //            Guard *= 2;
        //            Console.WriteLine($"{Name} use Rage.");
        //        }
        //        else if (base.Change_Health >= MaxHealth * 0.5 && Switchs && !DeadPerson)
        //        {
        //            Switchs = false;
        //            Guard /= 2;
        //            Console.WriteLine($"{Name} not use Rage. ");
        //        }
        //    }
        //}
        //public void Rage(IHealth unit)
        //{
        //    if (DeadPerson)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Unit died.");
        //        Console.ResetColor();
        //        return;
        //    }
        //    if (Change_Health < (MaxHealth / 2))
        //    {
        //        Damage += Damage / 2;
        //        Console.WriteLine($"{Name} has less than half health: {Change_Health}/{MaxHealth}\n Damage: {Damage}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("");
        //    }
        //}

        public override void DecreaseHealth(int damage)
        {
            if (Guard > 0)
            {
                int new_damage = damage - Guard;
                base.DecreaseHealth(new_damage);
            }
            else 
            {
                base.DecreaseHealth(damage);
            }
            
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name} \n Health: {Change_Health}/{MaxHealth}\n Damage: {Damage}\n Guard: {Guard} \n Live? {!DeadPerson}");
        }

    }
}
