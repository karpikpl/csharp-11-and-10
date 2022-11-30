// ref: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#generic-attributes
// source: https://github.com/Burgyn/Sample.CSharp11/blob/main/Program.cs#L186


using System.Reflection;

// Before C# 11:
public class TypeAttribute : Attribute
{
    public TypeAttribute(Type type) => ParamType = type;

    public Type ParamType { get; }
}

public class GenericAttribute<T> : Attribute
{
    public T MyProperty { get; set; } = default!;

    public GenericAttribute(T value) => MyProperty = value;
}

// After C# 11
[Generic<int>(5)]
public class GenericAttributes : IFeature
{
    public static void ShowFeature()
    {
        Console.WriteLine("-----> Generic attributes");
        Console.WriteLine("Generic attributes are now supported");

        var attribute = typeof(GenericAttributes).GetCustomAttribute<GenericAttribute<int>>();
        Console.WriteLine($"Generic attribute value: {attribute?.MyProperty}");

        Console.WriteLine("\nPress [any] key to continue...");
        Console.ReadLine();
    }

    [Generic<string>("foo")]
    public void Method() { }

    // Before C# 11:
    [Type(typeof(string))]
    public void MethodOldWay() { }
}