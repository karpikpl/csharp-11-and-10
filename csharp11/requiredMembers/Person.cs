using System.Diagnostics.CodeAnalysis;

public class Person
{
    public required string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public required string LastName { get; init; }

    [SetsRequiredMembers]
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Person(string firstName)
    {
        FirstName = firstName;
    }

    public Person() { }

    public override string ToString()
    {
        return $"{FirstName} {MiddleName} {LastName}";
    }

    public static void ShowFeature()
    {
        var person = new Person("John 1", "Doe");
        Console.WriteLine($"Created Person 1: {person}");

        var person2 = new Person("John 2", null!);
        Console.WriteLine($"Created Person 2: {person2}");

        Person person3 = new() { FirstName = "John 3", LastName = "Doe" };
        Console.WriteLine($"Created Person 3: {person3}");

        // won't compile
        // Person person4 = new Person("John") { LastName = "Doe" };
        // Person person5 = new Person("John");
        // Person person6 = new();
    }
}