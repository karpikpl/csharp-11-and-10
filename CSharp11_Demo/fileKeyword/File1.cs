// ref: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#file-scoped-types
//
// Summary: useful for source generators to avoid naming collisions

file interface IWidget
{
    int ProvideAnswer();
}

file class HiddenWidget
{
    public int Work() => 42;
}

public class Widget : IWidget, IFeature
{
    public int ProvideAnswer()
    {
        var worker = new HiddenWidget();
        return worker.Work();
    }

    public static void ShowFeature()
    {
        Console.WriteLine("-----> Widget shows that two types can exist with the same name when file scope is used");

        Widget widget = new();
        Console.WriteLine($"Widget's answer to life the universe and everything: {widget.ProvideAnswer()}");

        Console.WriteLine("\nPress [any] key to continue...");
        Console.ReadLine();
    }
}