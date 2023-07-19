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


// int Readval(string msg)
// {
//     Console.WriteLine(msg);
//     int val = int.Parse(Console.ReadLine());
// return val;
// }

int CountOdd (int[]array)
{
    int sumOdd =0;
    for (int i=1; i<array.Length;i=i+2)
    {
        sumOdd=sumOdd+array[i];
    }
    return sumOdd;
}

int[] arr = GenArr(10,100,1000);

PrintArray(arr);
Console.WriteLine("Сумма элементов на нечетных позициях = "+CountOdd(arr));