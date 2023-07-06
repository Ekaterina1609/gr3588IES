//int Factorial (int n)

   // if(n==1) return 1;
  //  else return n * Factorial(n-1);
//}

//Console.WriteLine(Factorial(5));

//f(1)=1
//f(2)=1
//f(3)=2
//F(n)=F(n-1)+(f-2)

int Fibona (int n)
{
    if(n==1 || n==2) return 1;
    else return Fibona(n-1)+Fibona(n-2);
}
//Console.WriteLine(Fibona(6));

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(Fibona(i));
}