Задание:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение:

1. Пользователь вводит массив.
2. Создаем новый массив и заполняем его тем, что ввел пользователь.
3. Разбиваем строку на отдельные элементы. Разделителем является пробел.
4. Создаем новый массив, который станет результатом нашей программы.
5. Создаем цикл. Условие при котором цикл будет повторяться : длина строк должна быть <= 3
6. Если условие выполнется присваиваем значение текущего индекса заданного массива индексу нового массива, и выводим его на консоль, разделяя элементы пробелом.
7. Цикл выполняется до тех пор, пока индекс меньше длины массива, который ввел пользователь.
