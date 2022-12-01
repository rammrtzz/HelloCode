string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите номер дня: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if(userNumber > 7)
{
    Console.WriteLine("В неделе только 7 дней!");
}
else
{
userNumber = userNumber - 1;
Console.Write("Введенное число соответствует дню недели: ");
Console.WriteLine(days[userNumber]);
}
