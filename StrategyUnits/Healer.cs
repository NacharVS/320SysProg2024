using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : Unit, IMagicUnit
    {
        private int _mana;

        public Healer(string? name, int maxHealth, int maxMana) : base(name, maxHealth)
        {
            MaxMana = maxMana;
            _mana = maxMana;
        }

        public int Mana
        {
            get => _mana;
            set
            {
                if (value > Mana)
                {
                    if (value > MaxMana)
                        value = MaxMana;
                    Console.WriteLine($"{Name} восстановил ману на {value - Mana}. Текущая мана {value}/{MaxMana}");
                }
                else
                {
                    int waste = Mana - value;
                    if (value < 0)
                        value = 0;
                    Console.WriteLine($"{Name} потратил ману {waste}. Текущая мана {value}/{MaxMana}");
                }
                if (value <= 0)
                {
                    _mana = 0;
                    Console.WriteLine($"{Name} истратил всю ману");
                }
                else if (value > MaxMana)
                    _mana = MaxMana;
                else
                    _mana = value;
            }
        }
        public int MaxMana { get; set; }

        public void Heal(Unit unit)
        {
            if (!Alive)
            {
                Console.WriteLine($"{Name} мертв. Он не может лечить");
                return;
            }
            if (!unit.Alive)
            {
                Console.WriteLine($"{unit.Name} мертв. Его нельзя лечить");
                return;
            }
            if (unit.Health == unit.MaxHealth)
            {
                Console.WriteLine($"{unit.Name} имеет полное здоровье. Лечение не нужно");
                return;
            }
            if (Mana < 2)
            {
                Console.WriteLine($"{Name} имеет ману {Mana}/{MaxMana}. Для лечения нужно минимум 2 очка маны");
                return;
            }
            Console.WriteLine($"{Name} начал лечить {unit.Name}");
            int needHeal = unit.MaxHealth - unit.Health;
            int possibleHeal = Mana / 2;
            if (needHeal <= possibleHeal)
            {
                unit.Health = unit.MaxHealth;
                Mana -= needHeal * 2;
            }
            else
            {
                unit.Health += possibleHeal;
                Mana -= possibleHeal * 2;
            }
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит: {Name} Здоровье: {Health}/{MaxHealth} Мана: {Mana}/{MaxMana}");
        }
    }
}
