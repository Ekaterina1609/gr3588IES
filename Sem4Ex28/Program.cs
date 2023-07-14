int Readdata()
{
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
return num;
}


void Printdata(long a)
{
Console.WriteLine(a);
}

long CalcFactor (int a)
{
    long res=1;
for (int i = 1; i < a+1; i++) 
{res*=i;}
    return res; 
}

Printdata(CalcFactor(Readdata()));