Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num / 10) < 10)
{
    Console.WriteLine("Число двухзначное!");
}
else
{
    int tenner = (num / 10) % 10;
Console.WriteLine(tenner);
}

