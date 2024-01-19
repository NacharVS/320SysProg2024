using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Akifev320P;


//ps1.ShowInfo();

Peasant ps1 = new Peasant();
Support Support = new Support();
Footman footman = new Footman();
Support.Heal(ps1);
//ps1.ShowInfo();
Palladin palladin = new Palladin();
palladin.ShowInfo();


ps1.ShowInfo();
footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);

footman.InflictDamage(ps1);


footman.HealthIncreasedEvent += HealthIncrease;

footman.HealthDecreasedEvent += HealthDecrease;

ps1.HealthIncreasedEvent += HealthIncrease;

ps1.HealthDecreasedEvent += HealthDecrease;

Support.HealthIncreasedEvent += HealthIncrease;

Support.HealthDecreasedEvent += HealthDecrease;

palladin.HealthIncreasedEvent += HealthIncrease;

palladin.HealthDecreasedEvent += HealthDecrease;

palladin.The_punitive_sword_of_justice(ps1);

Support.Heal(ps1);





void HealthIncrease(string name, int health, int newHealth)
{
    Console.WriteLine($"HP у {name} поднялось на {newHealth - health}. Текущее HP - {newHealth}");
}
void HealthDecrease(string name, int health, int newHealth)
{
    Console.WriteLine($"HP у {name} уменьшилось на {health - newHealth}. Текущее HP - {newHealth}");
}

