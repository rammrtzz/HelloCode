int N = new Random().Next(1, 100);
N = Convert.ToInt32(N);
int[] array = new int[N];
int sum = 0;
int count = 0;

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.WriteLine(array[i]);
    if (array[i] > 0)
    {
        sum += array[i];
        count++;

    }


}
Console.WriteLine("Количество всех положительных чисел: " + count);
Console.WriteLine("Сумма всех положительных чисел: " + sum);

/*
Сгенерировать массив из N целых чисел от -100 до 100. Выведите на
экран количество положительных чисел и их сумму
*/