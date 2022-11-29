// ref: https://devblogs.microsoft.com/dotnet/welcome-to-csharp-11/#raw-string-literals
// from: https://github.com/Burgyn/Sample.CSharp11/blob/main/Program.cs

using System.Text;

public class Utf8StringLiterals : IFeature
{
    public static void ShowFeature()
    {
        Console.WriteLine("-----> UTF-8 string literals");

        // C# 10
        //byte[] array = Encoding.UTF8.GetBytes("Hello UTF-8 String Literals");

        // C# 11
        ReadOnlySpan<byte> span = "Hello UTF-8 String Literals"u8;
        byte[] array = "Hello UTF-8 String Literals"u8.ToArray();

        Console.WriteLine($"Starting string was {Encoding.UTF8.GetString(array)}. Array was {array.Length} bytes long. Span was {span.Length} bytes long.");
        Console.WriteLine();
    }
}