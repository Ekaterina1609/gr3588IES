int Readval(string msg)
{
    Console.WriteLine(msg);
    int val = int.Parse(Console.ReadLine());
return val;
}

string DectoBin (int num)
{
    string outBin = String.Empty;
    while(num>0)
    {
        outBin=num%2+outBin;
        num=num/2;
    }
    return outBin;
}

int num = Readval("Введите число");
Console.WriteLine("это число в двоичном виде =  "+DectoBin(num));
Console.WriteLine("8 разряд "+Convert.ToString(num,8));
Console.WriteLine("16 разряд "+Convert.ToString(num,16));