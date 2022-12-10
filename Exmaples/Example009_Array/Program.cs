int Max(int agr1, int arg2, int arg3)
{
    int result = agr1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 1, 21, 23, 65, 45, 98, 85, 15, 45 };

