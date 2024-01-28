using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class ZeelotKnight : Unit, IMagicUnitCapability, IInflictDamage
    {

        private int _change_manna;
        public int MaxManna { get; set; }
        private int _guard;
        public int Guard
        {
            get => IArmor.LevelArmor * 2 + _guard;
            set => _guard = value;
        }

        private int _damage;
        public int Damage
        {
            get => IInflictDamage.LevelWeapon* 2 + _damage;
            set => _damage = value;
        }
        //public int Shield { get; private set; }
        public ZeelotKnight(int change_health, int maxHealth, string? name, bool deadperson, int damage, int manna, int maxManna, int guard) : base(name, change_health, deadperson, maxHealth)
        {
            _change_manna = manna;
            MaxManna = maxManna;
            _guard = guard;
            _damage = damage;

        }

        public int Change_manna
        {
            get { return _change_manna; }
            set
            {
                int beginEnergy = _change_manna;
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
                if (value < beginEnergy)
                {
                    MannaDecreasedEvent.Invoke(_change_manna, this.Name, beginEnergy - value, MaxManna);
                }
                else if (value > beginEnergy)
                {
                    MannaIncreasedEvent.Invoke(_change_manna, this.Name, value - beginEnergy, MaxManna);
                }
            }
        }

        public void Prayer()
        {

            if (DeadPerson)
            {
                Console.WriteLine($"{Name} died and can't pray.");
                return;
            }
            else if(Change_manna >= 10)
            {
                Change_Health += 20;
                Change_manna -= 10;
                Console.WriteLine($"{Name} operation was successfully.");
            }
            else
            {
                Console.WriteLine("Not enough manna for pray.");
            }
        }
        //public override void HealthDecrease(int damage)
        //{
        //    if (Guard > 0)
        //    {
        //        int actualDamage = damage - Guard;
        //        base.DecreaseHealth(actualDamage);
        //    }
        //    else
        //    {
        //        base.DecreaseHealth(damage);
        //    }
        //}

        public void InflictDamage(IHealth unit)
        {
            //throw new NotImplementedException();
            unit.DecreaseHealth(Damage);
        }

        public void DecreaseManna(int manna)
        {
            //throw new NotImplementedException();
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
