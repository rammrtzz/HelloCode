void FillArray(int[] arr, int len)
{
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(1, 11);
        Console.WriteLine(arr[i]);
    }
    
}

int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

int sum = 0;
float result = 0;
int count = 0;

FillArray(array, N);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sum += array[i];
        count++;
    }
}
Console.WriteLine("Количество четных элементов: " + count);
Console.WriteLine("Сумма четных элементов: " + sum);

result = (float)sum / count;
Console.WriteLine(result);
