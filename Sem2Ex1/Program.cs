System.Random numberSintezator = new System.Random();
int number = numberSintezator.Next(10,100);
Console.WriteLine(number);
int firstnumber = number/10;
int secondnumber = number%10;
Console.WriteLine(firstnumber);
Console.WriteLine(secondnumber);   
if(firstnumber>secondnumber) Console.WriteLine(firstnumber);
else Console.WriteLine(secondnumber);

char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
int firstdigits = (digits[0])-48;
int seconddigits = (digits[1])-48;

int resultNum = firstdigits>seconddigits?resultNum=firstdigits:resultNum=seconddigits;
Console.WriteLine(resultNum);
Console.Write(firstdigits);
Console.Write(seconddigits);