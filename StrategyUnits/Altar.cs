using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Altar: IMagicUnitCapability
    {
        private int _change_manna;
        public int MaxManna { get; set; }
        public string Name { get; set; }
        public int Change_manna
        {
            get { return _change_manna; }
            set
            {
                int beginManna = _change_manna;
                if (value < 0)
                {
                    _change_manna = 0;
                }
                else
                {
                    if (value > MaxManna)
                        _change_manna = MaxManna;
                    else
                        _change_manna = value;
                }
                if (value < beginManna)
                {
                    MannaDecreasedEvent.Invoke(_change_manna, Name, beginManna - value, MaxManna);
                }
                else if (value > beginManna)
                {
                    MannaIncreasedEvent.Invoke(_change_manna, Name, value - beginManna, MaxManna);
                }
            }
        }

        public Altar(int change_manna, string? name, int maxManna)
        {
            _change_manna = change_manna;
            MaxManna = maxManna;
            Name = Name;
        }

        //
        public void RegenerationManna(IMagicUnitCapability unit)
        {
            while (Change_manna > 0)
            {
                if (unit.MaxManna <= unit.Change_manna)
                {
                    return;
                }
                if (Change_manna < 2)
                {
                    break;
                }
                unit.IncreaseManna(1);
                DecreaseManna(2);
            }
        }


        public void DoManna()
        {
            while (Change_manna != MaxManna)
            {
                IncreaseManna(2);
            }
        }
        public ZeelotKnight CreateZeelotKnight()
        {
            return new ZeelotKnight(55, 60, "Zealot knight", false, 6, 10, 30, 4);
        }
        public Palladin CreatePalladin()
        {
            return new Palladin(60, 65, "Paladin", false, 10, 30, 31, 5, 8);
        }
        public Cleric CreateCleric()
        {
            return new Cleric("Cleric", false, 15, 30, 20, 20, 4);
        }
        public void ShowInfoAboutAltar()
        {
            Console.WriteLine($"Manna right now: {Change_manna}.");
        }

        public void DecreaseManna(int manna)
        {
            Change_manna -= 2;
        }

        public void IncreaseManna(int manna)
        {
            Change_manna += manna;
        }

        public event IMagicUnitCapability.MannaChangedDelegate MannaDecreasedEvent;
        public event IMagicUnitCapability.MannaChangedDelegate MannaIncreasedEvent;
    }
}
