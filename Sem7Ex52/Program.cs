
int Readval(string msg)
{
    Console.WriteLine(msg);
    int val = int.Parse(Console.ReadLine());
    return val;
}
//метод генерации двумерного массива
int[,] Fill2Darray(int countRow, int countColumn, int top, int down)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {

        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = i+j;
        }
    }

    return array2D;
}
//замена элементов с обоими четными индексами на их квадраты
// void ArrayEvensquares(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i=i+2)
//     {
//         for(int j=0; j < array.GetLength(1); j=j+2)
//         {
// array[i,j]= array[i,j]*array[i,j];
//         }
//     }
// }

// void Print2Darray(int[,] arrayforprint)
// {
//     for (int i = 0; i < arrayforprint.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayforprint.GetLength(1); j++)
//         {
//             Console.Write(arrayforprint[i, j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.DarkBlue,ConsoleColor.Magenta,ConsoleColor.DarkCyan, ConsoleColor.Gray, ConsoleColor.Cyan,ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};
void Print2DarrayCol(int[,] arrayforprint)
{
    for (int i = 0; i < arrayforprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[new Random().Next(0, colors.Length-1)];
           // if (arrayforprint[i, j]>9)
            Console.Write("    ".Substring(arrayforprint[i,j].ToString().Length)+arrayforprint[i, j]);
            Console.ResetColor();
            // }
            // else 
            // {
            // Console.Write(arrayforprint[i, j]+"  ");
            // Console.ResetColor();
            // }
        }
        Console.WriteLine();
    }
}

// void SearchElem (int[,] array, int row, int col)
// {
//     if (row > array.GetLength(0) || col > array.GetLength(1)) {Console.WriteLine("Нет такого элемента массива");}
//     else{Console.WriteLine("Элемент массива по строке "+row+" и столбцу "+ col+ "равен = "+array[row-1,col-1]);}
// }

void SumofColumns (int[,]array)
{
    int res = 0;
    for(int j = 0; j < array.GetLength(1);j++)
    {
        for (int i = 0;i<array.GetLength(0);i++)
        {
            res=res+array[i,j];
        }
Console.WriteLine("столбец "+j+1+" : "+res+"; ");
res=0;
    }

}
int row = Readval("введите количество строк");
int col = Readval("введите количество столбцов");

// int findrow = Readval("Введите искомую строку");
// int findcol = Readval("Введите искомый столбец");
int [,] arr2 = Fill2Darray (row, col, 10, 99);
//ArrayEvensquares(arr2);

Print2DarrayCol(arr2);
SumofColumns(arr2);
// SearchElem (arr2, findrow, findcol);