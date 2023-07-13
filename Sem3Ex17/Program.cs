using System.Runtime.CompilerServices;

// Console.WriteLine("Введите координату х");
// int x = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Введите координату У");
// int y = int.Parse(Console.ReadLine()??"0");

//метод читает данные от пользователя
int Readdata(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

int x = Readdata("Введите координату х");
int y = Readdata("ведите координату У");

//определение четверти по координатам точки
void PrintQuarterTest ()
{
if (x>0&&y>0) Console.WriteLine("Точка в четверти 1");
if (x>0&&y<0) Console.WriteLine("Точка в четверти 2");
if (x<0&&y>0) Console.WriteLine("Точка в четверти 3");
if (x<0&&y<0) Console.WriteLine("Точка в четверти 4");
}
PrintQuarterTest();