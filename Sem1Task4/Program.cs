internal class Program
{
    private static void Main(string[] args)
    {
        int a = 44;
        int b = 5;
        int c = 78;
        if (a < b)
        {
            if (b < c)
            {
                Console.WriteLine(c);
            }
            else Console.WriteLine(b);
        }
        else
        {
            if (c < a)
            {
                Console.WriteLine(a);
            }
            else Console.WriteLine(c);
        }
    }
}