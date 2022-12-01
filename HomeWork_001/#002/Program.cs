
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int []{ num1, num2, num3};
int maxValue = numbers.Max();



Console.Write("Максимальное число: ");
Console.WriteLine(maxValue);


