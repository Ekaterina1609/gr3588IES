void FillArray(int[]collection)
{
    int length =collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[]col)
{
    int count=col.Length;
    int position=0;
    while (position<count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int IndexOf(int[]collection, int find)
{
    int count =collection.Length;
    int index=0;
    int position=-1;
    while(index<count)
    {
     if(collection[index]== find)  
     {
        position=index;
         break;
     }  
      index++;   
     
    }
   return position;
}

//int[] array = new int [10];
//FillArray(array);
//PrintArray(array);
//Console.WriteLine ();

//int pos = IndexOf(array, 51);
//Console.WriteLine (pos);


int[] arr = {15,7,2,4,3,2,5,};

void SortArr (int[]arr)
{
    int count = arr.Length;
    for (int i = 0;i < count; i++)
    {
Console.Write($"{arr[i]}");
    }
}

void SelectionSort(int[]arrforSort)
{
    for (int i=0;i<arrforSort.Length-1;i++)
    {
        int minPosition = i;
     
        for (int j=i+1; j<arrforSort.Length;j++)
        {
           if (arrforSort[j]<arrforSort[minPosition]) minPosition=j;
        }

        int temporary = arrforSort[i];
        arrforSort[i]= arrforSort[minPosition];
        arrforSort[minPosition] = temporary;
       
    }
}

PrintArray(arr);
SelectionSort(arr);
Console.WriteLine("");
PrintArray(arr);
