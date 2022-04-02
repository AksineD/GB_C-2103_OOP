using System.Text;

var testStr = "asdfghjkl zxcvbnm";
Console.WriteLine(testStr);
Console.WriteLine(StringRevers(testStr));

string StringRevers(string origin)
{
    var sb = new StringBuilder();
    for (var i = origin.Length - 1; i >= 0; i--)
    {
        sb.Append(origin[i]);
    }

    return sb.ToString();
}