namespace StrategyUnits
{
    internal class Barracs //Создает Боевых юнитов !!! БЕЗ МАННЫ !!!
    {
        public Footman CreateRecruit() //Рекрут
        {
            return new Footman(45, "Recruit", 1, 5);
        }

        public Footman CreateFootman() //Пехотинец
        {
            return new Footman(60, "Footman", 3, 7);
        }

        public Berserker CreateBerserker() //Берсекер
        {
            return new Berserker(120, "Berserker", 5, 15);
        }
    }
}
