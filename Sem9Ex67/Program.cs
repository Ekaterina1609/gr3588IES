int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintResult(string text)
{
    Console.WriteLine(text);
}

int RecSumofDigits(int M)
{
    int sum=0;
    if (M<10)
    {
        return M;
    }
    else
    {
        sum =   M%10+RecSumofDigits(M/10);
        return sum;
    }
}

int number =ReadData("Введите число M");
//int stop =ReadData("Введите число N");

Console.WriteLine("Сумма чисел = "+RecSumofDigits(number));
//PrintResult(resultline);