void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}


Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
int count = 1;
int sum = 0;
for (int i = 0; i < N; i++)
{
    sum = Convert.ToInt32(Math.Pow(count, 3));
    array[i] = sum;
    count++;

}



PrintArray(array);









/*
Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
3 -> [1, 8, 27].
5 -> [1, 8, 27, 64, 125]
Указание: Вывод массива вынести в отдельную функцию.
*/