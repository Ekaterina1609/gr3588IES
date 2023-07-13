void quarter1(int a)
{if(a==1) Console.WriteLine("интервал х от 0 до бесконечности; интервал у от 0 до бесконечности");
if(a==2) Console.WriteLine("интервал х от 0 до бесконечности; интервал у от -бесконечности до 0");
if(a==3) Console.WriteLine("интервал х от -бесконечности до 0 ; интервал у от 0 до бесконечности");
if(a==4) Console.WriteLine("интервал х от -бесконечности до 0 ; интервал у от -бесконечности до 0");

}

void quarterDef(){
Console.WriteLine("введите номер четверти");
int quarter = int.Parse(Console.ReadLine());
quarter1(quarter);
}

quarterDef();

