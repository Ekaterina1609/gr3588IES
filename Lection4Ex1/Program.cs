string[,] table = new string [2,5];
table[1,2]="слово";

for(int rows = 0; rows < 2;rows++)
{
    for (int cols = 0;cols<5;cols++)
    {
       // Console.WriteLine($"{table[rows,cols]}-");
    }
}

int[,]matrix = new int[2,4];
matrix[0,3]=4;
void PrintArr(int[,] matr)
{
for(int i=0;i<matr.GetLength(0);i++)
{
    for (int j=0;j<matr.GetLength(1);j++)
    Console.Write(matr[i,j]+" ");
    Console.WriteLine();
}}

void FillArr(int[,] matr)   
{
for(int i=0;i<matr.GetLength(0);i++)
{
    for (int j=0;j<matr.GetLength(1);j++)
    matr[i,j]=new Random().Next(1,10);
  
}}

//PrintArr(matrix);
int[,]arrforprint = new int[4,5];
FillArr(arrforprint);
PrintArr (arrforprint);
