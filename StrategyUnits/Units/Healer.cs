using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Healer : MagicUnit
    {
        private string _nameOfUnit;

        public Healer(int currentHealth, string? nameOfClass, int defense, int minDamage, int maxDamage, int manaPoints, int ArmorLevel, int WeaponLevel) : base(currentHealth, nameOfClass, defense, minDamage, maxDamage, manaPoints, ArmorLevel, WeaponLevel)
        {
            _nameOfUnit = NameOfUnit;
        }

        public string NameOfUnit
        {
            get { return _nameOfUnit; }
            set { _nameOfUnit = value; }
        }


        public void HealSomebody(Unit unit)
        {
            if (unit.IsDead)
            {
                Console.WriteLine("Вы не можете вылечить мертвого юнита\n");
                return;
            }
            while (ManaPoints > 0)
            {
                if (unit.CurrentHealth < unit.MaxHealth)
                {
                    ManaPoints -= 2;
                    Console.WriteLine($"Вылечили с {unit.CurrentHealth} до {unit.CurrentHealth + 1}. Мана: {ManaPoints} MP.\n");
                    unit.CurrentHealth++;
                }
                if (unit.CurrentHealth >= unit.MaxHealth)
                {
                    Console.WriteLine($"Лечение прошло!\n");
                    break;
                }

            }
            if (ManaPoints == 0)
            {
                Console.WriteLine(" Маны нет!!\n");
            }
        }


        public override void ShowInfo()
        {

        }
    }
}
