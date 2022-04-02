#region

using System.Text;

using ReverseString;

#endregion

Console.WriteLine("Revers string");
var testStr = "asdfghjkl zxcvbnm";
Console.WriteLine(testStr);
Console.WriteLine(StringRevers(testStr));

string StringRevers(string origin)
{
    var sb = new StringBuilder();
    for (var i = origin.Length - 1; i >= 0; i--) sb.Append(origin[i]);

    return sb.ToString();
}

Console.WriteLine(string.Empty.PadRight(50, '='));
Console.WriteLine("\nParsing file\n");
var s = new ParseFile();

var data = s.ReadFile("data_IN.txt");
s.PrintData(data);

for (var index = 0; index < data.Length; index++)
{
    s.SearchMail(ref data[index]);
}

Console.WriteLine(string.Empty.PadRight(50, '='));
Console.WriteLine("\nSaving file\n");
s.SaveData("data_OUT.txt", data);

Console.WriteLine(string.Empty.PadRight(50, '='));
Console.WriteLine("\nReading new file\n");
var data_new = s.ReadFile("data_OUT.txt");
s.PrintData("data_OUT.txt");