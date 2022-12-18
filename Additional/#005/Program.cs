int GetLengthOfNumber(int val)
{
    int count = 0;
    while (val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число больше 100: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N <= 100)
{
    Console.WriteLine("Введите число больше 100: ");
    N = Convert.ToInt32(Console.ReadLine());
}

int size = GetLengthOfNumber(N);
Console.WriteLine("Количество цифр в числе: " + size);

int N1 = N;
int N2 = N;
int[] subnumbers1 = new int[size];
int[] subnumbers2 = new int[size];
int[] subnumbers3 = new int[size];

for (int i = size - 1; i >= 0; i--)
{
    subnumbers1[i] = N % 10;
    N = N / 10;
}

for (int i = size - 1; i >= 0; i--)
{
    subnumbers2[i] = N1 / 10;
    N1 = N1 / 10;
}
    






for (int i = 0; i < subnumbers1.Length; i++)
{
    Console.WriteLine(" - " + subnumbers1[i]);
}
for (int i = 0; i < subnumbers2.Length; i++)
{
    Console.WriteLine(" -- " + subnumbers2[i]);
}
for (int i = 0; i < subnumbers3.Length; i++)
{
    Console.WriteLine(" --- " + subnumbers3[i]);
}


/*
Уровень MEDIUM+
Задача 1
Введем понятие «подчисло». «Подчислом» числа N назовем число M, которое
составлено из его цифр, путем отсекания одной или более цифр справа или
слева. Например, «подчисла» числа 1234 – это:
1
2
3
4
12
23
34
234
123
С клавиатуры вводится натуральное число N (N>100). Выяснить,
сколько «подчисел» имеет число N, а также сколько из них являются
простыми.
*/