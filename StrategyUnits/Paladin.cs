namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private int _magicDamage;
        private bool _holyArmor;
        public int MagicDamage
        {
            get { return _magicDamage; }
            set { _magicDamage = value; }
        }
        public bool HolyArmor
        {
            get { return _holyArmor; }
            set { _holyArmor = value; }
        }
        public Paladin(string? name, int maxHP, int protection, int damage, int maxMana, int magicDamage) : 
            base(name, maxHP, damage, protection, maxMana)
        {
            _magicDamage = magicDamage;
        }
        public void FireAttack(Unit unit)
        {
            if (DeadUnit == false)
            {
                if (Mana < 5)
                {
                    Console.WriteLine($"{Name} не хватает маны.\n");
                }
                else
                {
                    if (unit.CurrentHP == 0)
                    {
                        Console.WriteLine($"{unit.Name} мертв. Невозможно нанести урон.\n");
                    }
                    else
                    {
                        unit.CurrentHP -= 15;
                        Mana -= 5;
                        Console.WriteLine($"{Name} нанес магичский урон {unit.Name}.\n");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{this.Name} мертв.\n");
            }
        }
        public void ActivateHolyArmor(Unit unit)
        {
            if (CurrentHP < MaximumHP / 2)
            {
                _holyArmor = true;
                Protection += Protection / 2;
                Console.WriteLine($"{Name} активировал святую броню.\n");
            }
            else
            {
                _holyArmor = false;
                Protection = Protection;
                Console.WriteLine();
            }
        }
        public void HolyFire(Unit unit)
        {
            if (Mana > 0)
            {
                unit.CurrentHP -= (_magicDamage - unit.Protection);
                Mana -= 3;
            }
            else
            {
                Console.WriteLine($"{Name} не хватает маны. Текущая мана: {Mana}/{MaximumMana}.\n");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Unit: {Name} Health: {CurrentHP}/{MaximumHP} Damage: {Damage} Protection: {Protection}/{MaximumProtect} Energy: {Mana}/{MaximumMana} MagicDamage:{MagicDamage} HolyArmor: {HolyArmor} Weapon Level: {WeaponLvl} Armor Level: {ArmorLvl}\n");
            Console.WriteLine();
        }
    }
}
