// using System.ComponentModel.Design.Serialization;

// int num1 = int.Parse(Console.ReadLine()??"0");
// int num2 = int.Parse(Console.ReadLine()??"0");
// if(num1*num1==num2||num2*num2==num1)Console.Write("Число "+num1+" в квадрате равно "+num2+"или наоборот");
// else Console.Write("Не является");

void Test (int a, int b)
{
    bool R = (a/b==b);
    if (R) Console.WriteLine(b+" в квадрате равно "+a);
    else Console.WriteLine(b+"не является квадратным корнем "+a);
}

Test(2,4);
Test(4,2);