using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit 
    {
    //    private int _manna;
    //    private int _MaxManna;

    //    public int MaxManna
    //    {
    //      get { return _MaxManna; } 
    //      set { _MaxManna = value; }
    //    }
    //    public int Manna
    //    {
    //        get { return _manna; }
    //        set
    //        {
    //            if (value < 0)
    //                _manna = 0;

    //            else
    //            {
    //                if (value > MaxManna)
    //                    _manna = MaxManna;
    //                else
    //                    _manna = value;
    //            }

    //            if (value < _manna)
    //            {
    //                MannaDecreasedEvent.Invoke(this.Health, this.Name, _MaxManna - value);
    //            }
    //            else if (value > _manna)
    //            {
    //                MannaIncreasedEvent.Invoke(this.Health, this.Name, value - _MaxManna);
    //            }
    //        } 


    //    }

    //    public void GetInfoManna()
    //    {
    //        Console.WriteLine($"Character: {Name}, Manna: {Manna}");
    //    }
    //    public MagicUnit(int health, string? name, int damage, int MaxManna, int guard) : base(health, name, damage, guard)
    //    {
    //        _manna = MaxManna;
    //        _MaxManna = MaxManna;
    //    }


    //    public delegate void MannaChangedDelegate(int health, string? name, int manna);

    //    public event MannaChangedDelegate MannaIncreasedEvent;
    //    public event MannaChangedDelegate MannaDecreasedEvent;
    }
}
