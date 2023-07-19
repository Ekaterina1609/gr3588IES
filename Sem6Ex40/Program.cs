int Readval(string msg)
{
    Console.WriteLine(msg);
    int val = int.Parse(Console.ReadLine());
return val;
}

// void Print (int a, int b, int c)
// {
//     if((a+b>c)&&(a+c>b)&&(b+c>a)){ Console.WriteLine("Правило треугольника выполняется");}
//     else {Console.WriteLine("Правило треугольника выполняется");}
// }

bool Test(int a, int b, int c)
{
    return ((a+b>c)&&(a+c>b)&&(b+c>a));
}
int aa = Readval("Введите а");
int bb = Readval("Введите b");
int cc = Readval("Введите c");

if (Test(aa, bb, cc)) Console.WriteLine("выполняется");
else Console.WriteLine("не выполняется");