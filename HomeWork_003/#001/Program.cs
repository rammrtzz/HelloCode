Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number / 10000 > 9 | number / 10000 < 1)
{
    Console.WriteLine("Введенное число не соответствует требованиям!");
    number = Convert.ToInt32(Console.ReadLine());
}

if (number % 10 == number / 10000 & (number % 100) / 10 == (number / 1000) % 10)
{
    Console.WriteLine("Число полиндром!");
}
else
{
    Console.WriteLine("Число не полиндром!");
}