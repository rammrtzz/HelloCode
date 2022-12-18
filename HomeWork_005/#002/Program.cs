int[] CreateArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 1000);
    }
    return array;
}
int N = new Random().Next(1, 10);
Console.WriteLine("Количество элементов в массиве = " + N);
int[] arr1 = CreateArray(N);
int num = 0;

for (int i = 0; i < arr1.Length; i++) //условие поставлено на четные числа, потому что
                                      //при выводе номера заданы с №1, а индекс первого элемента в массиве - 0
{
    if (i % 2 == 0)
    {
        num += arr1[i];
    }
}

for (int i = 1; i <= arr1.Length; i++)
{
    Console.WriteLine(i + " - й элекмент массива: " + arr1[i - 1]);
}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях = " + num);






/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/