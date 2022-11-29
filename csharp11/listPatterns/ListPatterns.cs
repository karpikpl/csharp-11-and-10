// ref:
// source: https://github.com/RoundTheCode/CSharp11/blob/main/RoundTheCode.CSharp11/Features/ListPatterns.cs

public class ListPatterns : IFeature
{
    public bool Is_1_3_5(int[] myNumbers)
    {
        return myNumbers is [1, 3, 5];
    }

    public bool Is_1___5(int[] myNumbers)
    {
        return myNumbers is [1, _, 5];
    }

    public bool Is_1_DotDot_5(int[] myNumbers)
    {
        return myNumbers is [1, .., 5];
    }

    public bool Is_1_Over_5(int[] myNumbers)
    {
        return myNumbers is [1, .., >= 5];
    }

    public bool IsPalindrome(ReadOnlySpan<char> text)
    {
        return text switch
        {
            { Length: < 2 } => true,
            [var first, .., var last] when first != last => false,
            [var first, .. var middle, var last] when first == last => IsPalindrome(middle),
            _ => false
        };
    }

    public static void ShowFeature()
    {
        Console.WriteLine("-----> List patterns");
        Console.WriteLine("List patterns are now supported");

        var listPatterns = new ListPatterns();

        var myNumbers = new int[] { 1, 3, 5 };
        Console.WriteLine($"Is {string.Join(", ", myNumbers)} [1, 3, 5]? {listPatterns.Is_1_3_5(myNumbers)}");

        myNumbers = new int[] { 1, 2, 5 };
        Console.WriteLine($"Is {string.Join(", ", myNumbers)} [1, _, 5]? {listPatterns.Is_1___5(myNumbers)}");

        myNumbers = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Is {string.Join(", ", myNumbers)} [1, .., 5]? {listPatterns.Is_1_DotDot_5(myNumbers)}");

        myNumbers = new int[] { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine($"Is {string.Join(", ", myNumbers)} [1, .., >= 5]? {listPatterns.Is_1_Over_5(myNumbers)}");

        var text = "racecar";
        Console.WriteLine($"Is {text} a palindrome? {listPatterns.IsPalindrome(text)}");

        text = "racecars";
        Console.WriteLine($"Is {text} a palindrome? {listPatterns.IsPalindrome(text)}");

        text = "";
        Console.WriteLine($"Is {text} a palindrome? {listPatterns.IsPalindrome(text)}");

        text = "a";
        Console.WriteLine($"Is {text} a palindrome? {listPatterns.IsPalindrome(text)}");

        text = "eye";
        Console.WriteLine($"Is {text} a palindrome? {listPatterns.IsPalindrome(text)}");

        Console.WriteLine();
    }
}