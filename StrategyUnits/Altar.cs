using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        //    public Altar() 
        //    {
        //        MaxEnergy = 100;
        //    }
        //    private int _currentEnergy;
        //    public int MaxEnergy { get; private set; }

        //    public Altar(int maxEnergy)
        //    {
        //        _currentEnergy = MaxEnergy;
        //        MaxEnergy = maxEnergy;
        //    }

        //    public int CurrentEnergy
        //    {
        //        get => _currentEnergy;
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                _currentEnergy = 0;
        //            }
        //            else
        //            {
        //                if (value > MaxEnergy)
        //                {
        //                    _currentEnergy = MaxEnergy;
        //                }
        //                else
        //                {
        //                    _currentEnergy = value;
        //                }
        //            }
        //        }
        //    }
        //    public void ShowInfoAboutAltar()
        //    {
        //        Console.WriteLine($"Текущая мана: {_currentEnergy}/{MaxEnergy}.\n");
        //    }
        //    public void RecoverMP(MagicUnit magicUnit)
        //    {
        //        if (_currentEnergy > 0)
        //        {
        //            if (magicUnit.Mana < magicUnit.MaximumMana)
        //            {
        //                magicUnit.Mana += 10;
        //                _currentEnergy -= 10;
        //                ManaGetEvent.Invoke(magicUnit.Name, magicUnit.Mana);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Максимальное количество маны.");
        //            };
        //        }
        //        else
        //        {
        //            Console.WriteLine("Нет энергии в алтаре.");
        //        }
        //    }
        public ZealotKnight CreateZealotKnight()
        {
            return new ZealotKnight("Zealot knight", 120, 120, false, 50, 12, 70, 70);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin("Paladin", 100, 100, false, 40, 8, 60, 60, 10);
        }
        //public Cleric CreateCleric()
        //{
        //    return new Cleric("Cleric", 55, 30, 6, 40);
        //}
        //public delegate void ManaChangedDelegate(string name, int maxMana);
        //public event ManaChangedDelegate ManaGetEvent;
    }
}
