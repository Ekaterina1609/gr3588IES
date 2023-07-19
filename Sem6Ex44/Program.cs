using System.Reflection.Metadata.Ecma335;

int Readval(string msg)
{
    Console.WriteLine(msg);
    int val = int.Parse(Console.ReadLine());
return val;
}

string FibNum (int num)
{
    string res = "0, 1, ";
    int first = 0;
    int last = 1;
    int buff = 0;
    for (int i = 0;i < num; i++)
    {
        buff = first+last;

       res = res +buff+ ", ";
        first = last;
        last = buff;

    
}
return res;
}

int number = Readval("Введите количество чисел");
Console.WriteLine(FibNum(number));

