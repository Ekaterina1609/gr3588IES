int coordReadDatax1()
{
Console.WriteLine("введите число");
int x1 = int.Parse(Console.ReadLine());
return x1;
}

string PrintSquare (int a, int pow)
{
    string b=" ";
  for(int i=1; i<a+1; i++) {
b = b+" "+Math.Pow(i, pow);
}
return b;
}

int num = coordReadDatax1();

Console.WriteLine(PrintSquare(num,1));
Console.WriteLine(PrintSquare(num,3));