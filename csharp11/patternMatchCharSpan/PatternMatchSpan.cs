// ref: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#pattern-match-spanchar-or-readonlyspanchar-on-a-constant-string

public class PatternMatchSpan : IFeature
{
    public static void ShowFeature()
    {
        Console.WriteLine("-----> Pattern matching on Char Span");

        var span = "Hello, World!".AsSpan();

        Console.WriteLine($"My span \"{span}\":");

        if (span.StartsWith("Hello"))
        {
            Console.WriteLine("\tStarts with Hello");
        }

        if (span is { Length: > 0 })
        {
            Console.WriteLine("\tLength is greater than 0");
        }

        if (span is { IsEmpty: true })
        {
            Console.WriteLine("\tIs empty");
        }

        if (span is { Length: > 0, Length: < 20, Length: var length })
        {
            Console.WriteLine($"\tLength is greater than 0 and less than 20 and is {length}");
        }

        if (span is "Hello, World!")
        {
            Console.WriteLine("\tIs Hello, World!");
        }

        Console.WriteLine();
    }
}