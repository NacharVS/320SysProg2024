using static Interface.IArmItem;

namespace Interface
{
    internal class ButterflyKnife : IKnife
    {
        public event ShowInfoDelegate showInfoKnife;
        public int ClassArm => 2;
        public string Name => "Нож бабочка";

        public int Damage => 8;

        public int Bleeding => 4;

        public int TotalDamage = 0;
        public void Hit()
        {
            showInfoKnife.Invoke(Name, Damage, Bleeding, ClassArm);
            Random random = new Random();
            int rand = random.Next(0, 2);
            if (rand == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    TotalDamage += Bleeding;
                }
                TotalDamage += Damage;
                Console.WriteLine($"Враг получил кровотичение, общий урон = {TotalDamage}");
            }
            else
            {
                TotalDamage += Damage;
                Console.WriteLine($"Враг получл урон, но избежал кровотичения, общий урон = {TotalDamage}");
            }
        }
    }
}
