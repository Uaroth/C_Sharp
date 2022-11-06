
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg2;
    return result;
}

int a1 = 75;
int b1 = 23;
int c1 = 54;

int a2 = 13;
int b2 = 82;
int c2 = 25;


int a3 = 17;
int b3 = 28;
int c3 = 35;

int Max1 = Max(a1, b1, c1);
int Max2 = Max(a2, b2, c2);
int Max3 = Max(a3, b3, c3);
int max = Max(Max1, Max2, Max3);
Console.WriteLine(max);