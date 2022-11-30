using System.ComponentModel;
using System.Reflection.Metadata;

namespace CSharp10_Demo.Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# 10 New Features");
            Console.WriteLine("Improvements of structure types");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            var m1 = new Measurement();
            Console.WriteLine("new Measurement(): {0}", m1);  // output: NaN (Undefined)

            var m2 = default(Measurement);
            Console.WriteLine("default(Measurement): {0}", m2);  // output: 0 ()

            var ms = new Measurement[2]; //Here the array creation will populate each element with the default values.
            Console.WriteLine("new Measurement[2] joined: {0}", string.Join(", ", ms));  // output: 0 (), 0 ()

            //?? Why is the default value for Description not "Not Provided"?
            // Answer: https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.defaultvalueattribute?view=net-7.0#remarks
            // A DefaultValueAttribute will not cause a member to be automatically initialized with the attribute's value. You must set the initial value in your code.

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }

    public readonly struct Measurement
    {
        public Measurement()
        {
            Value = double.NaN;
            Description = "Undefined";
        }

        public Measurement(double value, string description)
        {
            Value = value;
            Description = description;
        }

        public double Value { get; init; }

        [DefaultValue("Not Provided")]
        public string Description { get; init; }

        public override string ToString() => $"{Value} ({Description})";
    }
}