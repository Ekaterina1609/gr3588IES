using System.Globalization;

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
            array2D[i, j] = new Random().Next(top, down + 1);
        }
    }

    return array2D;
}

void Print2Darray(int[,] arrayforprint)
{
    for (int i = 0; i < arrayforprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            Console.Write(arrayforprint[i, j]+" ");
        }
        Console.WriteLine();
    }
}

ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black, ConsoleColor.DarkBlue,ConsoleColor.Magenta,ConsoleColor.DarkCyan, ConsoleColor.Gray, ConsoleColor.Cyan,ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};
void Print2DarrayCol(int[,] arrayforprint)
{
    for (int i = 0; i < arrayforprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayforprint.GetLength(1); j++)
        {
            Console.ForegroundColor = colors[new Random().Next(0, colors.Length-1)];
            Console.Write(arrayforprint[i, j]+" ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = Readval("введите количество строк");
int col = Readval("введите количество столбцов");
int [,] arr2 = Fill2Darray (row, col, 10, 99);
Print2DarrayCol(arr2);
