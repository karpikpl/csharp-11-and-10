// ref: https://devblogs.microsoft.com/dotnet/early-peek-at-csharp-11-features/#c-11-preview-allow-newlines-in-the-holes-of-interpolated-strings
// source: 

public class StringInterpolation : IFeature
{
    void NewLinesInStringInterpolation()
    {
        const DayOfWeek day = DayOfWeek.Monday;

        string dayInfo = $"Today is {day switch
        {
            DayOfWeek.Saturday or DayOfWeek.Sunday => "weekend",
            _ => "working day"
        }}.";

        Console.WriteLine(dayInfo);

        var v = $"Count ist: {this.Is.Really.Something()
                                .That.I.Should(
                                    be + able)[
                                        to.Wrap()]}.";

        Console.WriteLine(v);
    }

    public static void ShowFeature()
    {
        Console.WriteLine("-----> String interpolation");
        Console.WriteLine("String interpolation allows new lines in the holes of interpolated strings.");

        new StringInterpolation().NewLinesInStringInterpolation();

        Console.WriteLine("\nPress [any] key to continue...");
        Console.ReadLine();
    }

    #region dummy code

    class class1
    {
        public class1 Really => this;

        public class1 Something() => this;
        public int[] Should(int num) => new[] { 5 };

        public class1 That => this;
        public class1 I => this;
        public int Wrap() => 0;
    }

    class1 Is { get; set; } = new class1();
    class1 to = new class1();
    int be = 1;
    int able = 2;

    #endregion
}