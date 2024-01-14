using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Cleric : Unit
    {
        private int _manna;
        public int MaxManna { get; private set; }
        public Cleric() : base(60, "Cleric")
        {
            _manna = 40;
            MaxManna = _manna;
        }
        public int Manna
        {
            get { return _manna; }
            set 
            { 
                if (value < 0)
                {
                    _manna = 0;
                }
                else if (value > MaxManna)
                {
                    _manna = MaxManna;
                }
                else
                {
                    _manna = value;
                }
            }
        }

        //Создал регенерацию маны у клирика взамен его здоровью (соотношение 1/3).
        //Причем у него должно быть не меньше половины здоровья, чтобы он не мог себя убить
        public void MannaRegen (Unit unit)
        {
            if (Health >= unit.MaxHealth / 2)
            {
                while (Manna < MaxManna && Health > unit.MaxHealth / 2)
                {
                    Health -= 3;
                    Manna += 1;
                }
            }
            else
            {
                Console.WriteLine("Low Health for regeneration Manna");
            }
            
        }

        public void Heal(Unit unit)
        {
            if (unit.Alive)
            {
                if (unit == this)
                {
                    while (Manna >= 1 && unit.Health < unit.MaxHealth)
                    {
                        unit.Health += 2;
                        Manna -= 1;
                    }
                }
                else
                {
                    while (Manna >= 2 && unit.Health < unit.MaxHealth)
                    {
                        unit.Health += 1;
                        Manna -= 2;
                    }
                }
            }
            else
            {
                Console.WriteLine("Unit dead");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} Manna: {Manna}" );
        }
    }
}
