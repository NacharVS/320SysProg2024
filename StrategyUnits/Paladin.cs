using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Paladin : ZealotKnight, IMagicBattleUnit, ICapability
    {
        private int _magicDamage;
        public bool CapabilityActive { get; set; }
        public Paladin(string? name, int health, int maxHealth, bool isDied, int defense, int damage, int energy, int maxEnergy, int magicDamage) : base(name, health, maxHealth, isDied, defense, damage, energy, maxEnergy)
        {
            MagicDamage = magicDamage;
            CapabilityActive = false;
        }
        public int MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }
        public void MagicAttack(IHealth unit)
        {
            DecreaseEnergy(2);
            unit.DecreaseHealth(MagicDamage);
        }
        public override int Health
        {
            get => base.Health;
            set
            {
                int pred_health = base.Health;
                if (value <= 0)
                {
                    base.Health = 0;
                    IsDead = true;
                    Console.WriteLine($"{this.Name} мертв.\n");
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        base.Health = MaxHealth;
                    }
                    else
                    {
                        base.Health = value;
                    }
                }
                if (CapabilityActive == false && base.Health < MaxHealth * 0.5)
                {
                    HolyArmor();
                }
                else if (CapabilityActive == true && base.Health >= MaxHealth * 0.5)
                {
                    HolyArmorDeactivation();
                }
            }
        }
        public void FireAttack(Unit unit)
        {
            if (IsDead == false)
            {
                if (Energy < 5)
                {
                    Console.WriteLine($"{Name} не хватает энергии.\n");
                }
                else
                {
                    if (unit.Health == 0)
                    {
                        Console.WriteLine($"{unit.Name} мертв. Невозможно нанести урон.\n");
                    }
                    else
                    {
                        unit.Health -= 15;
                        Energy -= 5;
                        Console.WriteLine($"{Name} нанес магичский урон {unit.Name}.\n");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{this.Name} мертв.\n");
            }
        }
        public void HolyArmor()
        {
            Defense += Defense / 2;
            CapabilityActive = true;
            Console.WriteLine($"{Name} активировал святую защиту!");
        }

        public void HolyArmorDeactivation()
        {
            CapabilityActive = false;
            Defense -= Defense / 2;
            Console.WriteLine($"У {Name} святая защита перестала быть активна!");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name} Здоровье: {Health}/{MaxHealth} Защита: {Defense} Урон: {Damage} Энергия: {Energy}/{MaxEnergy} Магический урон: {MagicDamage} Святая броня: {CapabilityActive}");
        }

        public void CapabilityActivate() { }
    }
}
