// int len=Readval("Введите длину массива");
// int minValue=Readval("Введите минимальное значение для задания массива");
// int maxValue =Readval("Введите максимальное значение для задания массива");
// //int num =Readval("Введите искомое число");

int[] GenArr(int len, int minValue, int maxValue)
{ 
    int[] arr = new int[len];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(minValue, maxValue+1);
}
return arr;
}

void PrintArray(int[] arrforPrint)
{
    for(int i=0; i<arrforPrint.Length-1;i++)
    {
        Console.Write(arrforPrint[i]+", ");
    }
    Console.Write(arrforPrint[arrforPrint.Length-1]);
    Console.WriteLine();
}


int Readval(string msg)
{
    Console.WriteLine(msg);
    int val = int.Parse(Console.ReadLine());
return val;
}

int CountEven (int[]array)
{
    int count =0;
    for (int i=0; i<array.Length;i++)
    {
        if(array[i]%2==0)count++; 
    }
    return count;
}

int[] arr = GenArr(10,100,1000);

PrintArray(arr);

Console.WriteLine("Количество четных жлементов в массиве "+CountEven(arr));