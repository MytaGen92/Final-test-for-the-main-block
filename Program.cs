string[] array = ["Hello", "2", "world", ":-)"];
string[] NewArray = new string[array.Length];

int symbol = 3;    // количество необходимых символов в строке

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= symbol)
    {
        NewArray[i] = array[i];
    }
}
var str = string.Join(" ", NewArray);
Console.WriteLine(str);