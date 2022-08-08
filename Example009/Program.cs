int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 13;
int b1 = 15;
int c1 = 34;
int a2 = 3;
int b2 = 76;
int c2 = 18;
int a3 = 115;
int b3 = 55;
int c3 = 21;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
              Max(a1, b1, c1),
              Max(a2, b2, c2),
              Max(a3, b3, c3));

Console.WriteLine(max);
