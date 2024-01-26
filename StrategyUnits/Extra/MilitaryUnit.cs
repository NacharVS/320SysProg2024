using StrategyUnits.Example;
using static System.Net.Mime.MediaTypeNames;
namespace StrategyUnits.Extra
{
    internal class MilitaryUnit { }
    //internal class MilitaryUnit : Unit
    //{
    ////public delegate void InflictDamageDelegate(int damage, int maxHP, int maxProtect, string nameDamaging, string nameDamaged);
    ////public event InflictDamageDelegate inflictDamageEvent;
    ////public event InflictDamageDelegate inflictDamageToProtectEvent;
    //public int Damage { get; set; }
    //public int Defense { get; set; }

    //public MilitaryUnit(string? name, int maxHealth, int health) : base(name, maxHealth, health)
    //{
    //    MaxHealth = maxHealth;
    //    Health = health;
    //}

    //public void InflictDamage(Unit unit) 
    //{
    //    if (DeadUnit == false)
    //    {
    //        if (unit.Protection > 0)
    //        {
    //            unit.Protection -= _damage;
    //            inflictDamageToProtectEvent.Invoke(_damage, unit.CurrentHP, unit.Protection, Name, unit.Name);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Защита пробита.\n");
    //            unit.CurrentHP -= _damage;
    //            inflictDamageEvent.Invoke(_damage, unit.CurrentHP, unit.Protection, Name, unit.Name);
    //        }
    //    }
    //    else
    //    { 
    //        Console.WriteLine($"{namee} мертв.\n");
    //    }
    //}

    //public void Attack(IHealth unit)
    //{
    //    throw new NotImplementedException();
    //}
    //}
}
