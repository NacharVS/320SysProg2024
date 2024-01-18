using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        public int _nameMagic;
        public int _mana;
        public int _maxMana;
        public int MaxMana
        {
            get { return _maxMana; }
            set { _maxMana = value; }
        }

        public MagicUnit(int atackValue, string Name) : base(atackValue, Name)
        {

        }

        public void Heal(Unit unit)
        {
            if (unit.Dead == true)
            {
                Console.WriteLine($"{unit.Name} мертв.");
                return;
            }
            else
            {
                while (_mana > 0)
                {
                    if (unit.CurentHealth < unit.MaxHealth)
                    {
                        _mana -= 2;
                        Console.WriteLine($"Здоровье от {unit.CurentHealth} до {unit.CurentHealth + 1}; Остатки маны: {_mana}");
                        unit.PravHealth = unit.CurentHealth;
                        unit.CurentHealth++;
                        
                    }
                    if (unit.CurentHealth >= unit.MaxHealth)
                    {
                        Console.WriteLine($"Исцелился.");
                        break;
                    }
                }
                if (Mana == 0)
                {
                    Console.WriteLine("Мана закончилась!");
                }

            }

        }

        public void Healself()
        {
            if (Dead == true)
            {
                Console.WriteLine("Лекарь мертв");
                return;
            }
            while (_mana > 0)
            {
                if (CurentHealth < MaxHealth)
                {
                    _mana--;
                    int finalHealth = CurentHealth + 2;
                    if (MaxHealth >= MaxHealth)
                        CurentHealth = MaxHealth;
                    else
                        CurentHealth += 2;
                    Console.WriteLine($"Здоровье от {CurentHealth} до {finalHealth}; Остаток маны: {_mana}");
                    //Health += 2;
                }
                if (CurentHealth >= MaxHealth)
                {
                    Console.WriteLine($"Исцелился.");
                    break;
                }
            }
            if (Mana == 0)
            {
                Console.WriteLine("Мана закончилась!");
            }
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                    _mana = 0;
                else
                    if (_mana > _maxMana)
                    _mana = _maxMana;
                else
                    _mana = value;
            }
        }

        public int MagicDamage
        {
            get { return _nameMagic; }
            set { _nameMagic  = value; }
        }
    }
}
