// int coordReadDatax1()
// {
// Console.WriteLine("введите координату х1 ");
// int x1 = int.Parse(Console.ReadLine());
// return x1;
// }

// int coordReadDatay1()
// {
// Console.WriteLine("введите координату y1 ");
// int y1 = int.Parse(Console.ReadLine());
// return y1;
// }

// int coordReadDatax2()
// {
// Console.WriteLine("введите координату х2 ");
// int x2 = int.Parse(Console.ReadLine());
// return x2;
// }
// int coordReadDatay2()
// {
// Console.WriteLine("введите координату y2 ");
// int y2 = int.Parse(Console.ReadLine());
// return y2;
// }
//int[] Coord()
//{

using System.Numerics;
using System.Runtime.Serialization.Formatters;
int[] coord(){
Console.WriteLine("Введите координаты точки 1");
char[] coord = Console.ReadLine().ToCharArray();
int length=coord.Length;
// Console.WriteLine("length"+length);
int border1 = 0;
int border2 = 0;
string x ="";
string y ="";
string z ="";
for(int i=0; i<length;i++)
{if(coord[i] == ','&&border1==0) border1=i;
else if(coord[i]==','&&border1>0) border2=i;
}
int xlength=border1;
int ylength=border2-border1-1;
int zlength=length-border2-1;

for (int j=0; j<border1;j++)
{
    x+=coord[j];
}
for (int k=border1+1;k<border2;k++)
{
    y+=coord[k];
}
for (int g=border2+1;g<length;g++)
{
    z+=coord[g];
}
int xd = int.Parse(x);
int yd =    int.Parse(y);
int zd = int.Parse(z);

int[] array = new int[3];
array[0] = xd;
array[1] = yd;
array[2] = zd;

// int x1=coord[0];
// int y1=coord[2];
// int z1=coord[4];
// Console.WriteLine("x-"+xd);
// Console.WriteLine("y-"+yd);
// Console.WriteLine("z-"+zd);
// Console.WriteLine("border1"+border1);
// Console.WriteLine("border2"+border2);
// Console.WriteLine("xlength"+xlength);
// Console.WriteLine("ylength"+ylength);
// Console.WriteLine("zlength"+zlength);
 return array;
 }
 int[] coord2(){
Console.WriteLine("Введите координаты точки 2");
char[] coord = Console.ReadLine().ToCharArray();
int length=coord.Length;
// Console.WriteLine("length"+length);
int border1 = 0;
int border2 = 0;
string x ="";
string y ="";
string z ="";
for(int i=0; i<length;i++)
{if(coord[i] == ','&&border1==0) border1=i;
else if(coord[i]==','&&border1>0) border2=i;
}
int xlength=border1;
int ylength=border2-border1-1;
int zlength=length-border2-1;

for (int j=0; j<border1;j++)
{
    x+=coord[j];
}
for (int k=border1+1;k<border2;k++)
{
    y+=coord[k];
}
for (int g=border2+1;g<length;g++)
{
    z+=coord[g];
}
int xd = int.Parse(x);
int yd =    int.Parse(y);
int zd = int.Parse(z);

int[] array = new int[3];
array[0] = xd;
array[1] = yd;
array[2] = zd;

// int x1=coord[0];
// int y1=coord[2];
// int z1=coord[4];
// Console.WriteLine("x-"+xd);
// Console.WriteLine("y-"+yd);
// Console.WriteLine("z-"+zd);
// Console.WriteLine("border1"+border1);
// Console.WriteLine("border2"+border2);
// Console.WriteLine("xlength"+xlength);
// Console.WriteLine("ylength"+ylength);
// Console.WriteLine("zlength"+zlength);
 return array;
 }
 //coord();

 //   return new int[] { 0,}
//}
// Console.WriteLine("Введите координаты точки 2");
// char[] coord2 = Console.ReadLine().ToCharArray();
// int x2=coord2[0];
// int y2=coord2[2];
// int z2=coord2[4];
// Console.WriteLine(coord2[2]);

double CalculateLength(int[] coord1, int[] coord2)
 {
double res = 0;
 res=Math.Sqrt((coord1[0]-coord2[0])*(coord1[0]-coord2[0])+(coord1[1]-coord2[1])*(coord1[1]-coord2[1])+(coord1[2]-coord2[2])*(coord1[2]-coord2[2]));
     return res;
}

 Console.WriteLine("Расстояние между точками - "+CalculateLength(coord(),coord2()));
