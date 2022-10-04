Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

Решение задачи

Вводим массив из строк.
Первоначальный массив вводися или с клавиатуры, или он задан на старте. Ввод сделан вводом с клавиатуры Да или Нет.

При вводе "1 - да" предлагается сначала ввести количество планируемых элементов массива (ввод реализован через *Convert.ToInt32*), затем заполнить этот массив.
При вводе "2 - нет' первоначальный массив имеет значение: {"888888", "9999999", "444444", "-6"} 
Переменная *lengthLimit* - согласно заданию равна 3.

*CheckArray* - Функция подсчёта количества элементов, размер которых меньше *lengthLimit*
Подсчёт осуществляется перебором элементов массива *array* и сравнением количества их элементов с переменной *lengthLimit*.
Результат выводится в переменную *elements*.
Инициализируется новый массив строк *newArray*, размером, равным переменной *elements*.

*FillNewArray* - Функция формирования нового массива строк.
Формирование осуществляется перебором элементов массива *array*, сравнением количества их элементов с переменной *lengthLimit* и добавлением в массив *newArray* элемента, удовлетворяющего условию.
На выходе метода получается заполненный массив строк *newArray*, удовлетворяющий условию, что и является решением задачи.
Получившийся массив выводим на экран с помощью метода *ShowArray*.
