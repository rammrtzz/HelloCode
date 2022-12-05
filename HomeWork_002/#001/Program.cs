Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int tenner = (num / 10) % 10;
Console.WriteLine(tenner);