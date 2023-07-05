internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 72, 3, 4, 72, 6 };
        int n = array.Length;
        int find = 72;
        int index = 0;
        while (index < n)
        {
            if (array[index] == find)
                {Console.WriteLine(index);
               break;
                }
            index++;
        }
        Console.WriteLine("end");
    }
}