// ref: https://devblogs.microsoft.com/dotnet/welcome-to-csharp-11/#raw-string-literals

public static class RawStringLiterals
{
    public static void ShowFeature()
    {
        var raw1 = """This\is\all "content"!""";
        Console.WriteLine(raw1);

        var raw2 = """""I can do ", "", """ or even """" double quotes!""""";
        Console.WriteLine(raw2);

        var xml = """
            <element attr="content">
            <body>
                This line is indented by 4 spaces.
            </body>
            </element>
            """;
        //  ^white space left of here is removed
        Console.WriteLine(xml);

        const string name = "John";
        const string lastName = "Doe";

        string json =
            $$"""
            {
                "Name": "{{name}}",
                "LastName": "{{lastName}}"
            }
            """;
        //  ^white space left of here is removed

        Console.WriteLine(json);
    }
}