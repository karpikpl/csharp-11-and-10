
// ref: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#auto-default-struct

public struct AutoStruct : IFeature
{
    // this now compiles
    public int X { get; set; }
    public string Name { get; set; }
    public decimal Value { get; set; }

    public static void ShowFeature()
    {
        Console.WriteLine("-----> Auto default in structs");
        Console.WriteLine("The C# 11 compiler ensures that all fields of a struct type are initialized to their default value as part of executing a constructor");
        var autoStruct = new AutoStruct();

        Console.WriteLine($"AutoStruct has default values for all fields: {autoStruct.X}, {autoStruct.Name}, {autoStruct.Value}");
        Console.WriteLine();
    }
}