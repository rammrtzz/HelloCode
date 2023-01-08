﻿Console.WriteLine("Задан массив из случайных неповторяющихся двухзначных чисел: ");
int[,] arr1 = new int[3, 4];
int control = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 4 - 1; j >= 0; j--)
    {
        Random rnd = new Random();
        control = rnd.Next(10, 100);
        foreach (int number in arr1)
        {
            if (number == control) break;
            else arr1[i, j] = control;
        }
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();

}
/*
Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел.
Напишите программу, которая будет построчно выводить массив.
Обратите внимание, что максимальный размер такого массива ограничен.
Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.
Например,
11 22 78
12 47 96
25 87 88
*/