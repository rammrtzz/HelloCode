int N = new Random().Next(1, 100);
N = Convert.ToInt32(N);
int[] array = new int[N];

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(-100, 100);
    if (array[i] < 0)
    {
        Console.WriteLine("Есть отрицательное число");
        break;
    }
    else if (i == N - 1)
    {
        Console.WriteLine("Отрицательных чисел нет в массиве");
    }
}















/*
Сгенерировать массив из N целых чисел от -100 до 100. Выясните,
содержатся ли в массиве отрицательные числа. На экран вывести только ответ:
«Да» или «Нет».
*/