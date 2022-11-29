// ref: https://github.com/dotnet/csharplang/blob/main/meetings/2022/LDM-2022-04-06.md#parameter-null-checking

public class ClassWithChecks : IFeature
{
    // this was proposed but ultimately delayed
    // see: https://github.com/dotnet/csharplang/blob/main/meetings/2022/LDM-2022-04-06.md#parameter-null-checking
    /*
    public static void ValidateParams(string name!!)
    {
        Console.WriteLine($"Name {name} it no null and has a length of {name.Length}");
    }
    */

    // this produces warning CS8625 when string doesn't allow nulls - fix: string? name
    public static void ValidateParams(string? name)
    {
        ArgumentNullException.ThrowIfNull(name);
        Console.WriteLine($"Name {name} it no null and has a length of {name.Length}");
    }

    // helper method
    static void CallWithTry(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void ShowFeature()
    {
        Console.WriteLine("-----> The !! null check operator");
        CallWithTry(() => ClassWithChecks.ValidateParams(null));
        Console.WriteLine();
    }
}
