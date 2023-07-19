Console.WriteLine("Решение системы уравнений типа у=к1*х+b1, y=k2*x+b2, y=k3*x+b3 и площади на их пересечении");
double k1= Readval("Введите k1");
double b1= Readval("Введите b1");
double k2= Readval("Введите k2");
double b2= Readval("Введите b2");
double k3= Readval("Введите k3");
double b3= Readval("Введите b3");
double Readval(string msg)
{
    Console.WriteLine(msg);
    double val = double.Parse(Console.ReadLine());
return val;
}

void PrintArr(double[] arr)
{
    for (int i = 0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine();
}
//string Equat (int k1, int k2, int b1, int b2)
double[] Equat (double k1, double k2, double b1, double b2)
{
double [] x1 = new double[2];
x1[0] = (b2- b1)/(k1-k2);
x1[1] = k1*(b2- b1)/(k1-k2) + b1;
return x1;
}

double length (double x1, double y1, double x2, double y2)
{
    //double s= (x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
    Console.WriteLine("Сумма квадратов катетов = "+(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
double len = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
return len;
}

double SquareTriangle (double a, double b, double c)
{
    double p = (a+b+c)/2;
    double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    return s;
}

double [] x1 = Equat (k1, k2, b1, b2);
PrintArr(x1);
double [] x2 = Equat (k1, k3, b1, b3);
PrintArr(x2);
double [] x3 = Equat (k2, k3, b2, b3);
PrintArr(x3);

double len1 = length(x1[0],x1[1],x2[0],x2[1]);
Console.WriteLine("Длина a = "+len1);
double len2 = length(x1[0],x1[1],x3[0],x3[1]);
Console.WriteLine("Длина b="+len2);
double len3 = length(x3[0],x3[1],x2[0],x2[1]);
Console.WriteLine("Длина c="+len3);
Console.WriteLine ("Площадь треугольника = "+SquareTriangle(len1,len2,len3));



//Console.WriteLine(Equat(k1, k2, b1, b2));

