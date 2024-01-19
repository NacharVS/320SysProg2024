using StrategyUnits;

Barracs barracs = new Barracs();
Footman footman = barracs.CreateRecruit();
footman.ShowInfo();



static void Method(int number)
{
    Console.WriteLine($"Health has changed. CurrentHealth{number}");
}

