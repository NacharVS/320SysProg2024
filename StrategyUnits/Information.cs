﻿//Здесь храниться краткая информация о всех классах.

//Класс Unit (Юнит)
//Хранит в себе: Здоровье, МаксимальноеЗдоровье, Наименование, Метод Передвижения, Метод Информации

//Класс Peasant (Крестьянин)
//Наследуется от базового класса Unit, Здоровье 30.

//Класс Footman (Пехотинец) -- Дамаг
//Наследуется от базового класса Unit, Здоровье 60.
//Хранит в себе: Урон (7), Метод НанесенияУрона.

//Класс Cleric (Церковник) -- Хилл
//Наследуется от базового класса Unit, Здоровье 40.
//Хранит в себе: Манну (20), МаксимальнуюМанну, Метод ЛеченияКогоЛибо, Метод ЛеченияСебя, Метод ПоказатьМанну.
//Метод Лечения КОГО-ЛИБО: 2 манны = 1 здоровье.
//Метод Лечения СЕБЯ: 1 манна = 2 здоровья.
//Может лечить настолько, насколько позволяет манна. Если манны нет - нет хилла.