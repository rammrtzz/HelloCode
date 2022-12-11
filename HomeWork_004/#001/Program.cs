Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int temp = A;
for (int i = 1; i < B; i++)
{
    A = A * temp;
}

Console.WriteLine("Число А в Степени В = " + A);


/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/