int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 12;
int a2 = 132;
int a3 = 45;
int b1 = 33;
int b2 = 89;
int b3 = 456;
int c1 = 45;
int c2 = 56;
int c3 = 25;


int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
