// Задайте число Н и выведите все натуральные числа от  Н до 1.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintResult(double text)
{
    Console.WriteLine("Функция Аккермана для М и N = "+text);
}

double RecurrAkkerman(double n, double m)
{
     if (n == 0)
    return m + 1;
  else
    if ((n > 0||n<0 ) && (m == 0))
      return RecurrAkkerman(n - 1, 1);
    else
      return RecurrAkkerman(n - 1, RecurrAkkerman(n, m - 1));
}

double numberN =ReadData("Введите число N - ");
double numberM=ReadData("Введите число M - ");
double resultline = RecurrAkkerman(numberM,numberN);
PrintResult(resultline);
