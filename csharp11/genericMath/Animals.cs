// ref: https://devblogs.microsoft.com/dotnet/preview-features-in-net-6-generic-math/
// example from https://github.com/Burgyn/Sample.CSharp11/blob/main/Program.cs

public class StaticInInterfaces : IFeature
{
    public static void NumberOfLegs<T>(T animal) where T : IAnimal
    {
        Console.WriteLine($"{typeof(T)} has {T.NumberOfLegs} legs");
    }

    public static void ShowFeature()
    {
        Console.WriteLine("-----> Other uses of static abstract members in interfaces");

        NumberOfLegs(new Dog());
        NumberOfLegs(new Snake());

        Console.WriteLine();
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