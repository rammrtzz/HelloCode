int N = new Random().Next(1, 110);
N = Convert.ToInt32(N);
int[] array = new int[N];

Console.WriteLine("Массив из " + N + " чисел");

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1, N);
    if (array[i] % 3 == 0 & array[i] % 5 == 0 & array[i] % 7 != 0)
    {
        Console.WriteLine(array[i]);
    }
}



//Сгенерировать массив из N целых чисел от 1 до 110.. Выведите на экран
//элементы, кратные трём и пяти, но не кратные семи.