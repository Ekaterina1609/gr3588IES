int Readdata()
{
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
return num;
}

void Printdata(int a)
{
Console.WriteLine(a);
}
//Printdata(readdata());

int CalculationSimple(int b)
{
    int quantity =1;
    for(int i = 10; i < b; i=i*10)
    {
if(b/i>0)quantity++;
    }
    return quantity;
}

int CalculationLog(int b)
{
    int quantity = (int)Math.Log10(b)+1;
    return quantity;
}

int number = Readdata();
DateTime d1 = DateTime.Now;
Printdata(CalculationLog(number));
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
Printdata(CalculationSimple(number));
Console.WriteLine(DateTime.Now-d2);