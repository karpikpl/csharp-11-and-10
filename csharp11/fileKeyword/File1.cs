// reference: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#file-scoped-types
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

public class Widget : IWidget
{
    public int ProvideAnswer()
    {
        var worker = new HiddenWidget();
        return worker.Work();
    }
}