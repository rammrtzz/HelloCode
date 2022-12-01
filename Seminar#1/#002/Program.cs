Console.WriteLine("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}
