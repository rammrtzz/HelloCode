int N = new Random().Next(1, 10);
int[] array = new int[N];
float average = 0;
double geometric = 1;
double geometricSum = 0;
float result = 0;

for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.WriteLine(" - " + array[i]);
    average += array[i];
    geometric *= array[i];
}
double s = 1 / (double)N;
average = (float)average / N;
geometricSum = Math.Pow(geometric, s);
result = average / (float)geometricSum;
Console.WriteLine("Для проверки: " + geometric);
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