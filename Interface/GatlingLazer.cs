using static Interface.IArmItem;

namespace Interface
{
    internal class GatlingLazer : IImpulsArm
    {
        public event ShowInfoDelegate showInfoImpulsArm;
        public int ClassArm => 1;
        public string Name => "Гатлинг-лазер";

        public int Damage => 20;

        public int ImpulsDamage => 10;

        public void Shoot()
        {
            showInfoImpulsArm.Invoke(Name, Damage,ImpulsDamage, ClassArm);
            Console.WriteLine("BBBBFFFFBBBFBFBFBF");
        }
    }
}
