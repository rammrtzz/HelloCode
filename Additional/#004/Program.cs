int N = new Random().Next(1, 100);
N = Convert.ToInt32(N);
int[] array = new int[N];
float average = 0;
float geometric = 0;
double geometricSum = 0;
float result = 0;

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1, 100);
    average += array[i];
    geometric *= array[i];
}
average = (float)average / array.Length;
geometricSum = Math.Pow(geometric, 1 / array.Length);
result = (float)average / geometricSum;
Console.WriteLine("Среднее арифметическое: " + average);
Console.WriteLine("Среднее геометрическое: " + geometricSum);
Console.WriteLine("Результат - среднее арифметическое / среднее геометрическое: " + result);


/*
Сгенерировать массив из N целых чисел от 1 до 100. Вычислить
величину
𝐴
𝐺
, где A – среднее арифметическое среди всех элементов массива, а
G – среднее геометрическое.
*/