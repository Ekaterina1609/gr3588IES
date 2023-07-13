int coordReadDatax1()
{
Console.WriteLine("введите координату х1 ");
int x1 = int.Parse(Console.ReadLine());
return x1;
}

int coordReadDatay1()
{
Console.WriteLine("введите координату y1 ");
int y1 = int.Parse(Console.ReadLine());
return y1;
}

int coordReadDatax2()
{
Console.WriteLine("введите координату х2 ");
int x2 = int.Parse(Console.ReadLine());
return x2;
}
int coordReadDatay2()
{
Console.WriteLine("введите координату y2 ");
int y2 = int.Parse(Console.ReadLine());
return y2;
}

double CalculateLength(int x1, int y1, int x2, int y2)
{
double res = 0;
res=Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return res;
}

Console.WriteLine(CalculateLength(coordReadDatax1(),coordReadDatay1(),coordReadDatax2(),coordReadDatay2()));
