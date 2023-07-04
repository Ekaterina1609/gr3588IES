Console.WriteLine("Напишите число");
string a = Console.ReadLine();
int b = int.Parse(a);
int c = 0;
string output = "";
int check=b/2;
int diff = check*2;
if (b>1){
    if (b-diff>0){
while (c+1<b)
{
    c=c+2;
    output = output + c+ "; ";
}
}
else 
{
while (c+1<b)
{
    c=c+2;
    output = output + c+ "; ";
}
}
}
Console.WriteLine(output);