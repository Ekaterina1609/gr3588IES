string Replace (string text, char oldValue, char newValue)
{
string result = String.Empty;
int length = text.Length;
for (int i = 0; i < length; i++) 
{
if (text[i] == oldValue) 
{
    result=result + $"{newValue}";
    }
else result = result+$"{text[i]}";
}
return result;
}
string text1 ="Жил был Кот";
string newText = Replace (text1,' ', '-');
Console.WriteLine (newText);
string newText2 = Replace (newText,'К', 'к');
Console.WriteLine (newText2);