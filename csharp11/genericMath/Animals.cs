// example from https://github.com/Burgyn/Sample.CSharp11/blob/main/Program.cs

public static partial class Extensions
{
    public static void NumberOfLegs<T>(this T animal) where T : IAnimal
    {
        Console.WriteLine($"{typeof(T)} has {T.NumberOfLegs} legs");
    }
}


public record Dog : IAnimal
{
    public static int NumberOfLegs => 4;
}

public record Snake : IAnimal
{
    public static int NumberOfLegs => 0;
}

public interface IAnimal
{
    static abstract int NumberOfLegs { get; }
}