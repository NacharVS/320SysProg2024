using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits.Units
{
    internal class ZealotKnight : MagicUnit
    {
        private string _nameOfUnit;

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }
        public ZealotKnight(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints, int ArmorLevel, int WeaponLevel) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, manaPoints, ArmorLevel, WeaponLevel)
        {
            _nameOfUnit = NameOfUnit;
        }

        public void Prayer()
        {
            if (!IsDead)
            {
                Console.WriteLine($"{NameOfUnit} мертв. Он не может восстановиться с помощью молитвы");
                return;
            }
            if (CurrentHealth == MaxHealth)
            {
                Console.WriteLine($"{NameOfUnit} фулл хп. Он не может восстановиться с помощью молитвы");
                return;
            }
            if (ManaPoints < 10)
            {
                Console.WriteLine($"{NameOfUnit} имеет  ману {ManaPoints}. Для молитвы нужно минимум  10 очка маны");
                return;
            }
            IncreaseEnergy(10);
            Console.WriteLine($"{NameOfUnit} молитва была прочтена.");
            GetHeal(20);
        }


        public void ShowInformation()
        {
            Console.WriteLine($"Персонаж: {NameOfClass}\n Здоровье: {CurrentHealth}/{MaxHealth} \n Урон: {MinDamage} Мана: {ManaPoints}/{MaxManaPoints} \n Живой: {!IsDead}");
        }
    }
}
