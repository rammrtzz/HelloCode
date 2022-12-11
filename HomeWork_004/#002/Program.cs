int GetLengthOfNumber(int val)
{
    int count = 0;
    while (val > 0)
    {
        val = val / 10;
        count++;
    }
    Console.WriteLine("Количество цифр в числе: " + count);
    return count;
}
int N = Convert.ToInt32(new Random().Next(1, int.MaxValue));
int result = 0;
Console.WriteLine("Случайное число: " + N);
int size = GetLengthOfNumber(N);
int divider = N;                                          // Введена для проверки по остаточному делению. Так как N в каждой итерации цикла должно меняться

for (int i = 0; i < size; i++)
{
    int lastDigit = N % 10;                              //находим последнюю цифру
    int examination = divider % lastDigit;               
    if (examination == 0)                                //если результат 0 значит текущая цифра соответствует нашим требованиям
    {
        result = result + (N % 10);
    }
    N = N / 10;

}

Console.WriteLine("Сумма цифр в числе = " + result);
