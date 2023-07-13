int num = new Random().Next(100,1000);
Console.WriteLine(num);
int a = num/100;
int b = num%10;
Console.WriteLine(a*10+b);