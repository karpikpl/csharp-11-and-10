// ref: https://devblogs.microsoft.com/dotnet/preview-features-in-net-6-generic-math/

using System.Numerics;

public class Total<T> : IIncrementOperators<Total<T>>
    where T : INumber<T>
{
    public T Value { get; private set; } = T.Zero;

    public static Total<T> operator ++(Total<T> value)
    {
        return new Total<T> { Value = value.Value + T.One };
    }
}

public class GenericMath : IFeature
{
    public static void ShowFeature()
    {
        Console.WriteLine("-----> Generic math");

        var totalInt = new Total<int>();
        totalInt++;
        totalInt++;
        Console.WriteLine($"Total int is {totalInt.Value} after two ++");

        var totalDec = new Total<decimal>();
        totalDec++;
        totalDec++;
        Console.WriteLine($"Total decimal is {totalDec.Value} after two ++");

        Console.WriteLine();
    }
}