// Задайте число Н и выведите все натуральные числа от  Н до 1.
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

string LinGenRecurr(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    else
    {
        string outline = num +" " + LinGenRecurr(num - 1);
        return outline;
    }
}

int number =ReadData("Введите число N");
string resultline = LinGenRecurr(number);
PrintResult(resultline);
