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

string RecMN(int M, int N)
{
    if (M > N)
    {
        return string.Empty;
    }
    else
    {
        string outline =   M+" "+RecMN(M+ 1,N);
        return outline;
    }
}

int number =ReadData("Введите число M");
int stop =ReadData("Введите число N");

string resultline = number<stop?RecMN(number, stop):RecMN(stop,number);
PrintResult(resultline);