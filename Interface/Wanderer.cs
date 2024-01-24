
namespace Interface
{
    internal class Wanderer
    {
        //public delegate void ShowInfoDelegate(string name, int damage, int otherDamaage, int classArm);

        public static string Names = "Wanderrer";
        public static void AttackImpuls(IImpulsArm impulsArm)
        {
            Console.WriteLine($"{Names} использовал для атаки: {impulsArm.Name}");
            impulsArm.Shoot();
        }
        public static void AttackKnife(IKnife knife)
        {
            Console.WriteLine($"{Names} использовал для атаки: {knife.Name}");
            knife.Hit();
        }
        public static void AttackBomb(IBomb bomb)
        {
            Console.WriteLine($"{Names} использовал для атаки: {bomb.Name}");
            bomb.BombAttack();
        }
    }
}
