int len=Readval("Введите длину массива");
int minValue=Readval("Введите минимальное значение массива");
int maxValue=Readval("Введите максимальное значение массива");
int num =Readval("Введите искомое число");

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

// int[] ReplaceArr (int[]arrforReplacement)
// {
//     for(int i =0; i<arrforReplacement.Length;i++)
//     {
//         if(arrforReplacement[i]>0)
//         { arrforReplacement[i]=new Random().Next(minValue-1,0);
//         }
//         else 
//         {arrforReplacement[i] = new Random().Next(0, maxValue+1);
//         }
//     }
//     return arrforReplacement;
// }

int Check(int[] arrforcheck, int a)
{ int check=-1;

    for(int i=0;i<arrforcheck.Length;i++)
    {
        if(arrforcheck[i] == a) 
        {
          check=i;
        Console.WriteLine("в массиве есть число "+a);
        break;
        }
    }
    if(check==-1) {
        Console.WriteLine("в массиве нет числа "+a);
        }
        return check;

}

int[]arr = GenArr(len, minValue, maxValue);

PrintArray(arr);
Console.WriteLine("Искомый элемент массива под номером "+Check(arr,num));

// ReplaceArr(arr);
//PrintArray(arr);