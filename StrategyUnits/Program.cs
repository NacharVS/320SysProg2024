using StrategyUnits;

//Footman footman = new Footman();
//Footman footman2 = new Footman();
//Peasant ps1 = new Peasant();
//Cleric cleric = new Cleric();
//Cleric cleric2 = new Cleric();

////ps1.ShowInfo();
////footman2.ShowInfo();
////footman.InflictDamage(ps1);
////footman.InflictDamage(footman2);
//Console.WriteLine("Первоначальные данные");
//ps1.ShowInfo();
//footman2.ShowInfo();
//cleric.ShowInfo();
//cleric.GetInfoCleric();

//Console.WriteLine("\nХилл пс1 Пеасант");
//cleric.HillOthers(ps1);
//ps1.ShowInfo();

//Console.WriteLine("\nПосле хилла:");
//cleric.ShowInfo();
//cleric.GetInfoCleric();


//Console.WriteLine("\nПосле хилла самого себя:");
//cleric.HillMyself(cleric);
//cleric.ShowInfo();
//cleric.GetInfoCleric();

//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);
//footman.InflictDamage(cleric2);

//Console.WriteLine("Первый клерик лечит второго");
//Console.WriteLine("Первый клерик");
//cleric.ShowInfo();
//cleric.GetInfoCleric();

//Console.WriteLine("Second клерик");
//cleric2.ShowInfo();
//cleric2.GetInfoCleric();
//cleric.HillOthers(cleric2);

//Console.WriteLine("\nПосле хилла:");
//Console.WriteLine("Первый клерик");
//cleric.ShowInfo();
//cleric.GetInfoCleric();
//Console.WriteLine("Second клерик");
//cleric2.ShowInfo();
//cleric2.GetInfoCleric();

////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
////Тестирование манны:
//Peasant ps1 = new Peasant();
//Footman footman = new Footman();
//Cleric cleric = new Cleric();

////Получение информации:
//ps1.ShowInfo();
//footman.ShowInfo();
//cleric.ShowInfo();
//cleric.GetInfoCleric();

////Нанесение урона Крестьянину:
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//footman.InflictDamage(ps1);
//ps1.ShowInfo();

//cleric.HillOthers(ps1);
//ps1.ShowInfo();
//cleric.GetInfoCleric();
//cleric.HillOthers(ps1);

//Console.WriteLine("Создаем еще 2 хиллеров, чтобы проверить лечение других.");
//Cleric cleric2 = new Cleric();
//Cleric cleric3 = new Cleric();

//ps1.ShowInfo();
//cleric2.GetInfoCleric();
//cleric3.GetInfoCleric();

//Console.WriteLine("\ncleric2 лечит ps1 еще на 10 единиц. Здоровье ps1 = 29");
////cleric2 лечит ps1 еще на 10 единиц. Здоровье ps1 = 29, манна клерика2 = 0
//cleric2.HillOthers(ps1);
//ps1.ShowInfo();
//cleric2.GetInfoCleric();

////Проверка на хилл при 0 манны:
//Console.WriteLine("\nПроверка на хилл при 0 манны:");
//cleric2.HillOthers(ps1);

////cleric3 лечит ps1 еще на 1 единиц. Здоровье ps1 = 30, манна cleric3 = 18
//Console.WriteLine("\ncleric3 лечит ps1 еще на 1 единиц. Здоровье ps1 = 30, манна cleric3 = 18");
//cleric3.HillOthers(ps1);
//ps1.ShowInfo();
//cleric3.GetInfoCleric();

////Тестирование хилла мертвого персонажа:
//Console.WriteLine("\nТестирование хилла мертвого персонажа.");
//Peasant ps2 = new Peasant(); //Создаем ps2

////Убиваем ps2
//footman.InflictDamage(ps2);
//footman.InflictDamage(ps2);
//footman.InflictDamage(ps2);
//footman.InflictDamage(ps2);
//footman.InflictDamage(ps2);
//ps2.ShowInfo();
//cleric3.HillOthers(ps2);
//ps2.ShowInfo();

////Проверка мертвого персонажа
//Console.WriteLine("\nПроверка мертвого персонажа");
//Footman footman2 = new Footman();
//footman2.ShowInfo();

////Атака footman1 на footman2
//footman.InflictDamage(footman2);
//footman.InflictDamage(footman2);
//footman.InflictDamage(footman2);
//footman.InflictDamage(footman2);
//footman.InflictDamage(footman2);
//footman.InflictDamage(footman2);
//footman.InflictDamage(footman2);
//footman.InflictDamage(footman2);
//footman.InflictDamage(footman2);
//footman2.ShowInfo();

////Проба атаки footman2
//Console.WriteLine("\nПроба атаки footman2");
//footman2.InflictDamage(ps1);

////Проверка Мертвых Клериков
//                                //НЕ РЕАЛИЗОВАНО ТО, ЧТО ПРИ МЕРТВОМ КЛЕРИКЕ МАННА = 0!!!
//Console.WriteLine("\nПроверка Мертвых Клериков");
//Cleric cleric4 = new Cleric(); //Жертва
//cleric4.ShowInfo();

////Нанесение урона клерику4
//Console.WriteLine("\nНанесение урона клерику4");
//footman.InflictDamage(cleric4);
//footman.InflictDamage(cleric4);
//footman.InflictDamage(cleric4);
//footman.InflictDamage(cleric4);
//footman.InflictDamage(cleric4);
//footman.InflictDamage(cleric4);
//cleric4.ShowInfo();
//cleric4.GetInfoCleric();

////cleric4.HillMyself(cleric4);
//cleric4.HillOthers(footman2);
//cleric4.GetInfoCleric();

////Создание клерика5 для проверки манны
//Cleric cleric5 = new Cleric();
//cleric5.GetInfoCleric();

////Создание футмена для нанесения урона, чтобы потом восстановить здоровье, тем самым потратив манну клерику 5
//Footman footman2 = new Footman();
//Peasant ps1 = new Peasant();

//footman2.InflictDamage(ps1);
//footman2.InflictDamage(ps1);
//footman2.InflictDamage(ps1);
//ps1.ShowInfo();

////Хилл
//cleric5.HillOthers(ps1);
//ps1.ShowInfo();
//cleric5.GetInfoCleric();

////Проверка восстановления через 5 секунд
//cleric5.GetInfoCleric();
//cleric5.GetInfoCleric();
//cleric5.GetInfoCleric();
//cleric5.GetInfoCleric();
//cleric5.GetInfoCleric();

//Создание паладдина
//Palladin palladin1 = new Palladin();
//palladin1.ShowInfo();
//palladin1.GetInfoManna();

//Footman footman1 = new Footman();
//Footman footman2 = new Footman();
//Cleric cleric = new Cleric();

//footman1.InflictDamageEvent += MethodYron;
//footman2.InflictDamageEvent += MethodYron;
//palladin1.InflictDamageEvent += MethodYron;

//cleric.HillEvent += MethodHill;

////footman1.HealthChangedEvent += Method;
////footman2.HealthChangedEvent += Method;
////palladin1.HealthChangedEvent += Method;

//footman2.InflictDamage(palladin1);
//cleric.HillOthers(palladin1);
////footman1.ShowInfo();
////palladin1.MagicAttack(footman1);
////footman1.ShowInfo();
////palladin1.MagicAttack(footman1);
////footman1.ShowInfo();
////palladin1.MagicAttack(footman1);
////footman1.ShowInfo();
////palladin1.MagicAttack(footman1);
////palladin1.MagicAttack(footman2);
////palladin1.MagicAttack(footman2);
////palladin1.GetInfoManna();

////Создание Алтаря
//Console.WriteLine("\n\tALTAR");
//Altar altar1 = new Altar();
//altar1.ShowInfoAltar();

//altar1.RegenerationManna(cleric);
//cleric.GetInfoManna();
//altar1.ShowInfoAltar();

//Barracs barracs = new Barracs();
//Altar alt = new Altar();

//Cleric cleric = alt.CreateCleric();
//Palladin palladin = alt.CreatePalladin();
//Footman footman = barracs.CreateFootman();
//Berserker berserker = barracs.CreateBerserker();
//berserker.InflictDamageEvent += MethodYron;

//cleric.ShowInfo();
//palladin.ShowInfo();
//footman.ShowInfo();
//berserker.ShowInfo();


////Атака берсерка на футмена
//Console.WriteLine("\n");
//berserker.InflictDamage(footman);
//berserker.InflictDamage(footman);
//berserker.InflictDamage(footman);
//palladin.HillyArmor(footman);
//palladin.HillyArmor(footman);
//palladin.HillyArmor(footman);
//palladin.ShowInfo();


//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! ГЛОБАЛЬНОЕ ТЕСТИРОВАНИЕ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
Console.WriteLine("Создание всех игровых юнитов. Вывод информации о них.\n");  //Успешно
Barracs barracs = new Barracs();
Altar altar = new Altar();
Forge forge = new Forge();

Peasant peasant_1 = new Peasant(); //Нет метода
Peasant peasant_2 = new Peasant(); //Нет метода
Peasant peasant_3 = new Peasant(); //Нет метода
Peasant peasant_4 = new Peasant(); //Нет метода
Footman footman_1 = barracs.CreateRecruit(); //Атака
Footman footman_2 = barracs.CreateFootman(); //Атака
Berserker berserker_1 = barracs.CreateBerserker(); //Атака, ярость
ZeelotKnight zeelotKnight_1 = altar.CreateZeelotKnight(); //Атака, Магический урон
Palladin palladin_1 = altar.CreatePalladin(); // Атака, СвятойОгонь, СвятаяЗащита
Cleric cleric_1 = altar.CreateCleric(); //Атака, ХиллСебя, ХиллДругого
Cleric cleric_2 = altar.CreateCleric(); //Атака, ХиллСебя, ХиллДругого

peasant_1.ShowInfo();
peasant_2.ShowInfo();
footman_1.ShowInfo();
footman_2.ShowInfo();
berserker_1.ShowInfo();
zeelotKnight_1.ShowInfo();
palladin_1.ShowInfo();
cleric_1.ShowInfo();

//Проверка методов и ивентов КАЖДОГО.
footman_1.InflictDamageEvent += MethodYron;
footman_2.InflictDamageEvent += MethodYron;
berserker_1.InflictDamageEvent += MethodYron;
zeelotKnight_1.InflictDamageEvent += MethodYron;
palladin_1.InflictDamageEvent += MethodYron;
cleric_1.InflictDamageEvent += MethodYron;
cleric_1.HillEvent += MethodHill;
cleric_2.HillEvent += MethodHill;

Console.WriteLine("\nПроверка методов и ивентов АТАК.\n"); //Успешно
footman_1.InflictDamage(peasant_1);
footman_2.InflictDamage(peasant_1);
berserker_1.InflictDamage(peasant_1);
zeelotKnight_1.InflictDamage(peasant_2);
palladin_1.InflictDamage(peasant_2);
cleric_1.InflictDamage(peasant_2);

Console.WriteLine("\n");

berserker_1.Rage(peasant_3);
peasant_3.ShowInfo();
Console.WriteLine("\n");
zeelotKnight_1.MagicAttack(peasant_3);
peasant_3.ShowInfo();
Console.WriteLine("\n");
palladin_1.MagicAttack(peasant_4);
peasant_4.ShowInfo();

Console.WriteLine("\nПроверка методов и ивентов ХИЛЛА.\n"); //Успешно
cleric_1.HillOthers(peasant_4);
Console.WriteLine("\n");
palladin_1.InflictDamage(cleric_2);
Console.WriteLine("\n");
cleric_2.HillMyself(cleric_2);

Console.WriteLine("\nПроверка методов и ивентов Клерика, Рыцаря, Палладина, Берсерка.\n");
Console.WriteLine("\nБерсерка: при здоровье меньше 50% - не совершает метод Ярость\n"); //Успешно
berserker_1.ShowInfo();
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);
palladin_1.InflictDamage(berserker_1);

berserker_1.Rage(cleric_1);

////Проверка восстановления манны.
//Console.WriteLine("\nПроверка восстановления манны через Алтарь.\n");
//altar.RegenerationManna(cleric_1);
//cleric_1.ShowInfo();

//Console.WriteLine("\nПроверка восстановления манны через Алтарь (манна макисмальная).\n");
//altar.RegenerationManna(cleric_2);


//Проверка кузницы.
Console.WriteLine("\nПроверка Кузницы. ОРУЖИЕ.\n");
footman_1.ShowInfo();
forge.UpgradeDamage(footman_1);
forge.UpgradeDamage(footman_1);
forge.UpgradeDamage(footman_1);

Console.WriteLine("\nПроверка Кузницы. ЗАЩИТА.\n");
footman_1.ShowInfo();
forge.UpgradeArmor(footman_1);
forge.UpgradeArmor(footman_1);
forge.UpgradeArmor(footman_1);

//zeelotKnight_1.ShowInfo();
//palladin_1.ShowInfo();
//cleric_1.ShowInfo();


static void MethodYron(int damage, int health, string nameDealtDamage, string nameReceivedDamage)
{
    Console.WriteLine($"{nameDealtDamage} совершил атаку на {nameReceivedDamage}.\n{nameReceivedDamage} получил урон {damage}. Текущее здоровье {nameReceivedDamage}: {health}.");

}

static void MethodHill(int manna, int health, string nameHiller, string nameHill)
{
    Console.WriteLine($"{nameHiller} восстановил здоровье {nameHill} до {health}.\nТекущая манна {nameHiller}: {manna}");

}

static void MethodUpgradeDamage (string? name, int lever, int damage)
{
    Console.WriteLine($"{name} улучшил уровень атаки. \tТекущая атака: {damage} уровня {lever}");
}

static void MethodUpgradeArmor(string? name, int lever, int armor)
{
    Console.WriteLine($"{name} улучшил уровень защиты. \tТекущая защита: {armor} уровня {lever}");
}
