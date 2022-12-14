namespace CSharp10_Demo.Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# 10 New Features");
            Console.WriteLine("Record Structs");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            var p1 = new Person_ReferenceType { FirstName = "Raiford", LastName = "Bonnell" };
            var p2 = new Person_ValueType { FirstName = "Petter", LastName = "Smith" };
            var p3 = new Person_Class { FirstName = "John", LastName = "Doe" };

            Console.WriteLine("record class (Reference Type) Before: " + p1);
            Console.WriteLine("record struct (Value Type) Before: " + p2);
            Console.WriteLine("class (Reference Type) Before: " + p3);
            Console.WriteLine(CheckName(p1, p2, p3) ? "Yes" : "No");
            Console.WriteLine("record class (Reference Type) After: " + p1);
            Console.WriteLine("record struct (Value Type) After: " + p2);
            Console.WriteLine("class (Reference Type) After: " + p3);

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }

        private static bool CheckName(Person_ReferenceType prt, Person_ValueType pvt, Person_Class pc)
        {
            if (prt.LastName == "Peter")
            {
                prt.LastName = "Bad";
                pvt.LastName = "Good";
                pc.LastName = "Middle";
                return false;
            }
            else
            {
                prt.LastName = "Good";
                pvt.LastName = "Bad";
                pc.LastName = "Middle";
                return true;
            }
        }
    }

    public record struct Person_ValueType
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"({LastName}, {FirstName})";
    }

    public record Person_ReferenceType //class is implied here
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override sealed string ToString() => $"({LastName}, {FirstName})";
    }

    public class Person_Class
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        
        public override string ToString() => $"({LastName}, {FirstName})";
    }
}