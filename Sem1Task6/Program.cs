Console.WriteLine   ("Напишите число");
string a = Console.ReadLine();
int b = int.Parse(a);
int c=b/2;
int diff = c*2;
if (b-diff>0)
{
    Console.WriteLine("Есть остаток");
        }
        else Console.WriteLine("Без остатка");