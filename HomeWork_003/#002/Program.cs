int[] firstDot = new int[3];
int[] secondDot = new int[3];
int result = 0;
double square = 0;
double distance = 0;

Console.WriteLine("Введите координаты точек: ");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Введите " + (i + 1) + " -й координат точки A");
    int dotA = Convert.ToInt32(Console.ReadLine());
    firstDot[i] = dotA;

    Console.WriteLine("Введите " + (i + 1) + " -й координат точки B");
    int dotB = Convert.ToInt32(Console.ReadLine());
    secondDot[i] = dotB;
}

for (int i = 0; i < 3; i++)
{
    result = (firstDot[i] - secondDot[i]);
    square = square + Math.Pow(result, 2);
    distance = Math.Sqrt(square);
    
}
Console.WriteLine("Расстояние между этими точками " + distance);



