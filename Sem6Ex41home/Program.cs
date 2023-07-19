int Readval(string msg)
{
    Console.WriteLine(msg);
    int val = int.Parse(Console.ReadLine());
return val;
}

int PosNumbers(int num)

{
    int res = 0;
    int temp=0;
    for (int i = 0;i<num;i++)
    {
       temp = Readval("Введите число");
       if (temp >0) res++;
    }   
    return res; 
}

int number = Readval("Введите количество символов для ввода");
Console.WriteLine("Количество положительных = "+PosNumbers(number));