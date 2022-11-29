// ref: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#extended-nameof-scope
// from: https://github.com/Burgyn/Sample.CSharp11/blob/main/Program.cs

using System.Reflection;

public class MyAttribute : Attribute
{
    public string ParamName { get; private set; }

    public MyAttribute(string paramName)
    {
        ParamName = paramName;
    }
}
public class NameOfScope
{
    [My(nameof(foo))]
    public void Method(int foo, [My(nameof(foo))] int anotherParam)
    { }

    public static void ShowFeature()
    {
        Console.WriteLine("-----> Extended nameof scope");

        var method = typeof(NameOfScope).GetMethod(nameof(Method))!;
        var methodAttribute = method.GetCustomAttribute<MyAttribute>()!;
        Console.WriteLine($"Method attribute param name: {methodAttribute.ParamName}");

        var myAttribute = method.GetParameters()[1].GetCustomAttribute<MyAttribute>()!;
        Console.WriteLine($"Param attribute param name: {myAttribute.ParamName}");

        Console.WriteLine();
    }
}