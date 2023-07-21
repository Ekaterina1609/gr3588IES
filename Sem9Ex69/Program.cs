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

int APowB(int A, int B)
{
    int res=1;
    if (B==1)
    {
        return A;
    }
    else
    {
        res =   A*APowB(A,B-1);
        return res;
    }
}

int MyPow(int a, int b)
{
    if(b==2)return a*a;
    if(b==1)return a;

    if(b%2==0)
    {
    return MyPow(a,b/2)*MyPow(a,b/2);
    }
    else
    {
    return MyPow(a,b/2)*MyPow(a,b/2+1);
    }
}


int numberA =ReadData("Введите число A");
int numberB =ReadData("Введите число B");
//int stop =ReadData("Введите число N");

Console.WriteLine("A в степени В = "+APowB(numberA, numberB));

Console.WriteLine("A в степени В = "+MyPow(numberA, numberB));
//PrintResult(resultline);