namespace StrategyUnits
{
    internal class Barracs //Создает Боевых юнитов !!! БЕЗ МАННЫ !!!
    {
        public Footman CreateRecruit() //Рекрут
        {
            return new Footman("Recruit", 45, 5);
        }

        public Footman CreateFootman() //Пехотинец
        {
            return new Footman("Footman", 60, 7);
        }

        public Berserker CreateBerserker() //Берсекер
        {
            return new Berserker("Berserker", 120, 15, 7);
        }
    }
}
