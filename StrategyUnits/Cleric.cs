namespace StrategyUnits
{
    internal class Cleric : MagicUnit
    {
        public Cleric(string? name, int maxHP, int damage,  int protection, int maxMana) : base(name, maxHP, damage, protection, maxMana) { }
        public void Heal(Unit unit)
        {
            if (unit.DeadUnit == false)
            {
                if (Mana > 2)
                {
                    while (unit.CurrentHP < unit.MaximumHP)
                    {
                        unit.CurrentHP++;
                        Mana -= 2;
                    }
                    HealEvent.Invoke(Mana, unit.CurrentHP, Name, unit.Name);
                    ManaLossEvent.Invoke(Name, Mana);
                }
                else
                {
                    Console.WriteLine($"{this.Name} не хватает маны.\n");
                }
            }
            else
            {
                Console.WriteLine($"{unit.Name} мертв. Вы не можете вылечить его.\n");
                return;
            }
        }

        public delegate void HealDelegate(int mana, int maxHP, string nameHealer, string nameHealing);

        public event HealDelegate HealEvent;
        public delegate void ManaChangedDelegate(string name, int maxMana);
        public event ManaChangedDelegate ManaLossEvent;
    }
}
