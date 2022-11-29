// from: https://github.com/Burgyn/Sample.CSharp11/blob/main/Program.cs
using System.Reflection;

public class MyAttribute : Attribute
{
    public string ParamName {get; private set;}

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

    public static void RunChecks()
    {
        var method = typeof(NameOfScope).GetMethod(nameof(Method))!;
        var methodAttribute = method.GetCustomAttribute<MyAttribute>()!;
        Console.WriteLine($"Method attribute param name: {methodAttribute.ParamName}");

        var myAttribute = method.GetParameters()[1].GetCustomAttribute<MyAttribute>()!;
        Console.WriteLine($"Param attribute param name: {myAttribute.ParamName}");
    }
}