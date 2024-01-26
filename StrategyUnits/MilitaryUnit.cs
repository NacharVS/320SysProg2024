using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit: Unit, IGuard
    ////{
    ////    private int _damage;
    ////    public int Damage
    ////    {
    ////        get { return _damage; }
    ////        set { _damage = value; }
    ////    }
    ////    public int Health { get; set; }
    ////    public virtual void InflictDamage(Unit unit)
    ////    {
    ////        if (DeadPerson)
    ////        {
    ////            Console.ForegroundColor = ConsoleColor.Red;
    ////            Console.WriteLine("Unit died");
    ////            Console.ResetColor();
    ////        }

    ////        if (this.Damage > Guard)
    ////        {
    ////            //Console.WriteLine($"Unit нанес {unit.Name} урон {_damage}");
    ////            unit.Health -= (this.Damage - unit.Guard);
    ////        }
    ////        else
    ////        { 
    ////            unit.Health -= 0;
    ////            //InflictAttackEvent.Invoke(_damage, unit.Health, Name, unit.Name);
    ////        }
    ////    }

    ////    public MilitaryUnit(int health, string? name, int damage, int guard) : base(health, name, guard)
    ////    {
    ////        _damage = damage;
    ////        Health = health;
    ////        Grd = guard;
    ////    }


    ////    public override void ShowInfo()
    ////    {
    ////        Console.WriteLine($" Unit: {Name} Health: {Health} Damage: {Damage} Level Weapon: {LevelWeapon} LevelArmor: {LevellArmor}");
    ////        Console.WriteLine();
    ////    }

    ////    public delegate void InflictAttackDelegate(int damage, int health, string name_n, string name_p);
    ////    public event InflictAttackDelegate InflictAttackEvent;
    }
}
