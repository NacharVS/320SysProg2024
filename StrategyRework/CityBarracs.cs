namespace StrategyRework
{
    internal class CityBarracs
    {
        public Peasant CreatePeasant()
        {
            return new Peasant("Крестьянин", 50);
        }
        public Berserker Createberserker()
        {
            return new Berserker("Берсерк", 120, 5, 10, 2, 0, 0);
        }
        public Cleric CreateClerik()
        {
            return new Cleric("Хилир", 100, 70, 6, 0);
        }
        public ZeelotKnight CreateZeelotKnight()
        {
            return new ZeelotKnight("Магический фанатик", 140, 60,3,9, 4, 0,0);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin("Паладиин", 110, 70, 4, 9,11,0,0);
        }
    }
}
