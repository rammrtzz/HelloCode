int Max(int agr1, int arg2, int arg3)
{
    int result = agr1;
    if (arg2 > result) result = arg2;
    if (arg3 >result) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 21;
int c1 = 39;
int a2 = 121;
int b2 = 212;
int c2 = 393;
int a3 = 124;
int b3 = 215;
int c3 = 396;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));
Console.WriteLine(max);