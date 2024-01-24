using static Interface.IArmItem;

namespace Interface
{
    internal class FragBomb : IBomb
    {
        public event ShowInfoDelegate showInfoBomb;
        public int ClassArm => 3;
        public int BombDamage => 20;

        public string Name => "Осколочная граната";

        public int Damage => 15;

        public void BombAttack()
        {
            showInfoBomb.Invoke(Name, Damage, BombDamage, ClassArm);
            Console.WriteLine("Ba bah bdsh");
        }
    }
}
