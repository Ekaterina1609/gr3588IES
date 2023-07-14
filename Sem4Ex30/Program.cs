using System.Reflection.Metadata.Ecma335;

int Readdata()
{
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
return num;
}

void Printdata(int a)
{
Console.WriteLine(a);
}


int[] GenArray (int len)
{
int[]outArray = new int[len];

for (int i = 0;i<len ;i++)
{
    outArray[i]= new Random().Next(0,2);
}
return outArray;
}

void PrintArray(int[] arrayforprint)
{
Console.Write("[");
for(int i=0;i<arrayforprint.Length-1;i++)
{
    Console.Write(arrayforprint[i]+", ");
}
Console.Write(arrayforprint[arrayforprint.Length-1]+"]");
}

PrintArray(GenArray(Readdata()));