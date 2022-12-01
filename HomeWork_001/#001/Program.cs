Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2)
{
    Console.WriteLine("Первое число больше!");
}
else if (num1 < num2)
{
    Console.WriteLine("Второе число больше!");
}
else
{
    Console.WriteLine("Оба числа равны!");
}



