Console.WriteLine("Решение системы уравнений типа у=к1*х+b1, y=k2*x+b2");
int k1= Readval("Введите k1");
int b1= Readval("Введите b1");
int k2= Readval("Введите k2");
int b2= Readval("Введите b2");

int Readval(string msg)
{
    Console.WriteLine(msg);
    int val = int.Parse(Console.ReadLine());
return val;
}

string Equat (int k1, int k2, int b1, int b2)
{
string answer = String.Empty;
int x = (b2- b1)/(k1-k2);
int y = k1*(b2- b1)/(k1-k2) + b1;

answer = "x = "+x+", y = "+y;
return answer;
}

Console.WriteLine(Equat(k1, k2, b1, b2));

