double[] CreateArray(int length)
{
    double[] array = new double[length];
    
    Random rnd = new Random();
    
    for (int i = 0; i < length; i++)
    {
       array[i] = rnd.Next(1, 1000) * 0.01;
    }
    return array;
}
int N = new Random().Next(1, 10);
Console.WriteLine("Количество элементов в массиве = " + N);
double[] arr1 = CreateArray(N);

Console.WriteLine("Максимальный элекмент массива: " + arr1.Max());
Console.WriteLine("Минимальный элекмент массива: " + arr1.Min());
double result = arr1.Max()- arr1.Min();
Console.WriteLine("Разница между ними: " + result);

for (int i = 1; i <= arr1.Length; i++)
{
    Console.WriteLine(i + " - й элекмент массива: " + arr1[i - 1]);
}














/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

[3.3 7.76 22 2 78.67] -> 76.67
*/