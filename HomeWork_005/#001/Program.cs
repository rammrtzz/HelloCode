int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
int N = new Random().Next(1, 10);
Console.WriteLine("Количество элементов в массиве = " + N);
int[] arr1 = CreateArray(N);
int num = 0;

for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i] % 2 == 0)
    {
        num++;
    }
}

for (int i = 1; i <= arr1.Length; i++)
{
    Console.WriteLine(i + " - й элекмент массива: " + arr1[i-1]);
}

Console.WriteLine("Количество четных элементов массива = " + num);






/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/