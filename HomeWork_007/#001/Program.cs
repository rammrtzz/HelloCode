int m = 3;
int n = 4;
double[,] arr1 = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = n-1; j >= 0; j--)
    {
        Random rnd = new Random();
        arr1[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}






/*
Задача 1. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
m = 3, n = 4.
0.5 7.96 -2.78 -0.2
1.7 -3.3 8.574 -9.9
8.5 7.87 -7.1 9.15
*/