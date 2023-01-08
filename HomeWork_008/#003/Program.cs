Console.WriteLine("Заданы два массива из случайных чисел: ");
int[,] arr1 = new int[3, 3];
int[,] arr2 = new int[3, 3];
int[,] resultArray = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Random rnd = new Random();
        arr1[i, j] = rnd.Next(1, 10);
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Random rnd = new Random();
        arr2[i, j] = rnd.Next(1, 10);
        Console.Write(arr2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Результат: ");
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {

        for (int k = 0; k < 3; k++)
        {
            resultArray[i, j] += (arr1[i, k] * arr2[k, j]);
        }

        Console.Write(resultArray[i, j] + " ");
        resultArray[i, j] = 0;

    }
    Console.WriteLine();
}





/*
Задача 3: Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18
*/