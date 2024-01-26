using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Akifev320P;


//ps1.ShowInfo();

Peasant ps1 = new Peasant();
Support support = new Support();
Barracs barracs = new Barracs();
Footman footman = barracs.CreateFootman();
//ps1.ShowInfo();


ps1.HealthDecreasedEvent += HealthDecrease;
ps1.HealthIncreasedEvent += HealthIncrease;

Palladin palladin = new Palladin();

Console.WriteLine(footman.Damage);



ps1.ShowInfo();
footman.InflictDamage(ps1);

palladin.The_punitive_sword_of_justice(ps1);
palladin.ShowInfo();


static void HealthIncrease(string name, int health, int newHealth)
{
    Console.WriteLine($"HP у {name} поднялось на {newHealth - health}. Текущее HP - {newHealth}");
}
static void HealthDecrease(string name, int health, int newHealth)
{
    Console.WriteLine($"HP у {name} уменьшилось на {health - newHealth}. Текущее HP - {newHealth}");
}


ps1.ShowInfo();
support.Heal(ps1);
footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

support.Heal(ps1);

Console.ReadKey();