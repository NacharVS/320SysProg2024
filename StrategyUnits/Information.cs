﻿//Здесь храниться краткая информация о всех классах.

//Класс Unit (Юнит)
//Хранит в себе: Здоровье, МаксимальноеЗдоровье, Наименование, Метод Передвижения, Метод Информации

//Класс Peasant (Крестьянин)
//Наследуется от базового класса Unit, Здоровье 30.

//Класс Footman (Пехотинец) -- Дамаг
//Наследуется от базового класса MilitaryUnit, Здоровье 60, Урон (1-7) - СДЕЛАТЬ РАНДОМ

//Класс Cleric (Церковник) -- Хилл
//Наследуется от базового класса MagicUnit, Здоровье 40, УронОбычный (1-4), Манна 20
//Метод Лечения КОГО-ЛИБО: 2 манны = 1 здоровье.
//Метод Лечения СЕБЯ: 1 манна = 2 здоровья.
//Может лечить настолько, насколько позволяет манна. Если манны нет - нет хилла.


//Unit -> MilitaryUnit -> Footman
//                     -> MagicUnit -> Cleric
//                                  -> Palladin

//Класс MilitaryUnit (Военный Юнит)
//Наследуется от базового класса Unit
//Хранит в себе: Урон, МетодНанесенияУрона

//Класс MagicUnit (Магические Юниты)
//Наследуется от Unit.
//Хранит в себе: Манну, МаксимальнуюМанну, Метод ПоказатьМанну

//Класс Palladin -- УронОбычный, УронМагический
//Наследуется от MagicUnit, Здоровье 95, УронОбычный (1-10), УронМагический (10-15), Манна 35