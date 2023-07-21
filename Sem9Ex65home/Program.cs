// Задайте число Н и выведите все натуральные числа от  Н до 1.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintResult(int text)
{
    Console.WriteLine("Сумма натуральных чисел между M - N = "+text);
}

int SumGenRecurr(int m, int n)
{
    int res=0;
    if (m >=n)
    {
        return n;
    }
    else
    {
        res = m + SumGenRecurr(m + 1,n);
        return res;
    }
}

int numberM =ReadData("Введите число M");
int numberN =ReadData("Введите число N");
int resultline = SumGenRecurr(numberM,numberN);
PrintResult(resultline);
