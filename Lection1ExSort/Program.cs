int Max (int arg1, int arg2, int arg3)
{
    if (arg1 < arg2 )
    {
        if (arg2<arg3)
        {
            return arg3;
        }
        else return arg2;
    }
    else if (arg1 < arg3) {return arg3;}
     else return arg1;
}
int a1 =11;
int b1 = 42;
int c1 = 33;
int a2 = 1;
int b2 = 2;
int c2 = 3;
int a3 = 111;
int b3 = 2;
int c3 = 3;

int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max =Max (max1,max2,max3);
Console.WriteLine(max);
