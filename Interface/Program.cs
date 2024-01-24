using Interface;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

Wanderer wan = new Wanderer();
GatlingLazer lazer = new GatlingLazer();
ButterflyKnife knife = new ButterflyKnife();
FragBomb fragBomb = new FragBomb();
lazer.showInfoImpulsArm +=ShowInfo;
knife.showInfoKnife +=ShowInfo;
fragBomb.showInfoBomb +=ShowInfo;

Wanderer.AttackBomb(fragBomb);

Wanderer.AttackKnife(knife);

Wanderer.AttackImpuls(lazer);


static void ShowInfo(string name, int damage, int otherDamage, int classArm)
{
    if (classArm == 1)
    {
        Console.WriteLine($"{name} имеет {damage} обычного урона и {otherDamage} импульсного урона");
    }
    else if (classArm == 2)
    {
        Console.WriteLine($"{name} имеет {damage} обычного урона и возможность нанести {otherDamage} урона кровотичением которе наносит тройной урон (только кровотичением).");
    }
    else if (classArm == 3)
    {
        Console.WriteLine($"{name} имеет {damage} обычного урона и {otherDamage} осколочного урона");
    }
}

