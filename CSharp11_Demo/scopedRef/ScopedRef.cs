// ref: https://prographers.com/blog/c-11-ref-fields-and-ref-scoped-variable

public class ScopedRef : IFeature
{
    ref struct Test
    {
        private ReadOnlySpan<char> _characters;

        // thanks to scoped ref compiler knows the stack allocated memory won't outlive the ref struct
        public void TestMethod(scoped ReadOnlySpan<char> characters)
        {
            // The body of the method must only use characters in the local scope, and cannot assign it directly to any field or classes unless they themselves would be scoped.
            using StringWriter sw = new StringWriter();
            sw.Write(characters);
            Console.WriteLine(sw.ToString());

            // won't compile
            // Cannot use variable 'ReadOnlySpan<char>' in this context because it may expose referenced variables outside of their declaration scope [csharp-11-and-10]csharp(CS8352)
            // _characters = characters;
        }
    }

    public static void ShowFeature()
    {
        Console.WriteLine("-----> ref fields and ref scoped variable");

        // value declared on the stack
        Span<char> values = stackalloc char[3] { 'T', 'o', 'm' };
        new Test().TestMethod(values);

        Console.WriteLine();
    }
}