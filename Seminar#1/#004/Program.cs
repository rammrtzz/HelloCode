Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int j = Math.Abs(numberA);

int i = - j;

while (j >= i)
{
    Console.WriteLine(j);
    j--;
}
