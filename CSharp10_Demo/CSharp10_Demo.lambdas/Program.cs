namespace CSharp10_Demo.lambdas
{
    internal class Program
    {
        private static Func<string, int> parse_func;

        static void Main(string[] args)
        {
            Console.WriteLine("C# 10 New Features");
            Console.WriteLine("Natural types for lambdas");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            var parse_lambda = (string s) => int.Parse(s);
            parse_func = parse_lambda;
            Console.WriteLine($"Parsed 525: {parse_func("525")}");

            var SomethingElse = (int i) => { return i + 2; };
            Console.WriteLine($"Something Else: {SomethingElse(525)}");
            //parse_func = SomethingElse;

            // ERROR: Not enough type info in the lambda
            //var parse = s => int.Parse(s);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}