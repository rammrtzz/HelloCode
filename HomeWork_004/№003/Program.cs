int GetLengthOfNumber(int val)
{
    int count = 0;
    while (val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}

int count = 1;                             //счетчик для заполнения массива интересными числами

while (count < 11)
{
    int N = new Random().Next(10, 1000);    
    int size = GetLengthOfNumber(N);

    int[] interesticNumber = new int[10];
    int[] examination = new int[size];     // массив для сбора цифр из числа для проверки
    int temp = N;                          //сохраняю число N временную переменную, так как в процессе проверки число N меняется
    int sum = 0;
    int multiply = 1;

    for (int i = 0; i < size; i++)
    {
        examination[i] = N % 10;
        N = N / 10;
        sum = sum + examination[i];
        multiply = multiply * examination[i];
    }

    if (multiply % sum == 0)
    {
        interesticNumber[count-1] = temp;  //для более удобного вывода элементов массива, чтобы нумерация начиналась с 1
        Console.WriteLine(count + " -е интересное число! " + temp);
        count++;
    }

}

/*
Задача 3: **(Дополнительное, не обязательно)
Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на 10 «интересных» 
случайных целых чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)

[591, 532, 189, 523, 333, 546, 527, 275, 456, 264]
*/