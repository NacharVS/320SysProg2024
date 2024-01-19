namespace StrategyUnits
{
    internal class Barracs 
    {
        public Footman CreateRecruit() //Рекрут
        {
            return new Footman(45, "Recruit", 5);
        }

        public Footman CreateFootman() //Пехотинец
        {
            return new Footman(60, "Footman", 7);
        }

        public Berserker CreateBerserker() //Берсекер
        {
            return new Berserker(120, "Berserker", 15);
        }
    }
}
