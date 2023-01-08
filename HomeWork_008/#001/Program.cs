Console.WriteLine("Задан массив из случайных чисел: ");
int[,] arr1 = new int[3, 4];
int[] arr2 = new int[4];
for (int i = 0; i < 3; i++)
{
    for (int j = 4 - 1; j >= 0; j--)
    {
        Random rnd = new Random();
        arr1[i, j] = rnd.Next(1, 10);
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Упорядоченные строки массива по убыванию элементов строки: ");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        arr2[j] = arr1[i, j];
    }

    Array.Sort(arr2);
    Array.Reverse(arr2);

    for (int k = 0; k < 4; k++)
    {
        arr1[i, k] = arr2[k];
        Console.Write(arr1[i, k] + " ");
    }
    Console.WriteLine();
}









/*
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/