int digitCount = Convert.ToInt32(new Random().Next(1, 10));
int result = 0;
for (int i = 1; i <= digitCount; i++)
{
    Console.WriteLine("Введите " + i + " - е число " + " из " + digitCount);
    if (Convert.ToInt32(Console.ReadLine()) > 0) result++;
}
Console.WriteLine("Количество чисел больше 0 = " + result);









/*
Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Не использовать массив.

M=5 ; 0, 7, 8, -2, -2 -> 2
M=5 ; -1, -7, 567, 89, 223 -> 3
*/