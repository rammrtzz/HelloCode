int GetLengthOfNumber(int val)
{
    int count = 0;
    while (val > 0)
    {
        val = val / 10;
        count++;
    }
    Console.WriteLine(count);
    return count;
}
int N = new Random().Next(1, int.MaxValue);
Console.WriteLine(N);
int length = GetLengthOfNumber(N);
int[] digitsOfNumber = new int[length];

for(int i = 0; i < length; i++)
{
    digitsOfNumber[i] = N % 10;
    N = N /10;
    
}
Array.Reverse(digitsOfNumber);
for (int i = 0; i < length; i++)
{
    Console.WriteLine(digitsOfNumber[i]);
}