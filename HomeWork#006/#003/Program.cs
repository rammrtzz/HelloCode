int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}
int N = new Random().Next(1, 10);
Console.WriteLine("Количество элементов в массиве = " + N);
int[] arr1 = CreateArray(N);
int result = 0;
int j = arr1.Length - 1;
for (int i = 0; i < arr1.Length; i++)
{
    if (i == j | i > j) break;
    else result += arr1[i] * arr1[j];
    j--;
    Console.WriteLine("Произведение " + (i + 1) + " - й пары чисел массива " + result);
}
Console.WriteLine("Результат: " + result);
for (int i = 1; i <= arr1.Length; i++)
{
    Console.WriteLine(i + " - й элемент массива = " + arr1[i-1]);
}









/*
Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28
*/