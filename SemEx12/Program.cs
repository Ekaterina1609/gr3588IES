int num1 = int.Parse(Console.ReadLine()??"0");
int num2 = int.Parse(Console.ReadLine()??"0");
if(num1%num2>0) Console.WriteLine("Остаток "+ num1%num2);
else Console.WriteLine("Без остатка");