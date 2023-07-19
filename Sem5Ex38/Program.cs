double [] GenArr(int len, int minValue, int maxValue)
{ 
    double[] arr = new double[len];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(minValue, maxValue+1);
}
return arr;
}

void PrintArray(double[] arrforPrint)
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

double Diff (double[]array)
{
    double min = array[0];
    double max = array[0];  
    double diff = 0; 
    for (int i=1; i<array.Length;i++)
    {
        if (array[i]<min) min=array[i];
        if (array[i]>max) max=array[i];
    }
diff=max-min;
return diff;
}

double [] arr = GenArr(10, 0, 100);

PrintArray(arr);
Console.WriteLine("Разница между мах и мин = "+Diff(arr));