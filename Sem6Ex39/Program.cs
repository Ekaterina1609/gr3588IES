using System.ComponentModel.DataAnnotations;

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

void SwapArray (int[]arr)
{
    int temp =0;
for (int i=0; i<arr.Length/2;i++)
{
    temp =arr[i];
    arr[i] = arr[arr.Length-1-i];
    arr[arr.Length-1-i]=temp;
}
}

int[] ReverseArray (int[]arr)
{
    int[] res = new int[arr.Length];
for (int i=0; i<arr.Length;i++)
{
    res[i]=arr[arr.Length-i-1];
}
    return res;
}

int[]arr= GenArr(10,1,10);
PrintArray(arr);
SwapArray(arr);
PrintArray(arr);
PrintArray(ReverseArray(arr));
