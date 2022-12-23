int m = 3;
int n = 4;
double[,] arr1 = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = n - 1; j >= 0; j--)
    {
        Random rnd = new Random();
        arr1[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x >= arr1.GetLength(0) || y >= arr1.GetLength(1)) Console.WriteLine("Такого элемента нет в списке");
else Console.WriteLine("Запрошенный элемент массива: " + arr1[x, y]);





/*
Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

[1,7] -> такого числа в массиве нет
*/