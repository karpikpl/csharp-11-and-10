using System.Runtime.CompilerServices;

namespace CSharp10_Demo.ArgumentExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# 10 New Features");
            Console.WriteLine("Argument expressions");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            Action xAction_1 = () => Console.WriteLine("Done!");
            Action xAction_2 = null;
            try
            {
                Operation(xAction_1);
                Operation(xAction_2);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();

            var pt = new PartialType();
        }

        public static void ValidateArgument(string parameterName, bool condition, [CallerArgumentExpression("condition")] string? message = null)
        {
            if (!condition)
            {
                throw new ArgumentException($"Argument failed validation: <{message}>", parameterName);
            }
        }

        public static void Operation(Action func)
        {
            ValidateArgument(nameof(func), func is not null);
            func();
        }
    }

    public partial class PartialType
    {
        public partial void M1(int x);

        public partial T M2<T>(string s) where T : struct;

        public partial void M3(string s);


        public partial void M4(object o);
        public partial void M5(dynamic o);
        public partial void M6(string? s);
    }

    public partial class PartialType
    {
        // Different parameter names:
        public partial void M1(int y) { }

        // Different type parameter names:
        public partial TResult M2<TResult>(string s) where TResult : struct => default;

        // Relaxed nullability
        public partial void M3(string? s) { }


        // Mixing object and dynamic
        public partial void M4(dynamic o) { }

        // Mixing object and dynamic
        public partial void M5(object o) { }

        // Note: This generates CS8611 (nullability mismatch) not CS8826
        public partial void M6(string s) { }
    }
}