// helper method
void CallWithTry(Action action)
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

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Below some of the C# 11 features");
Console.WriteLine();

Widget widget = new();
Console.WriteLine("Widget shows that two types can exist with the same name when file scope is used");
Console.WriteLine($"Widget's answer to life the universe and everything: {widget.ProvideAnswer()}");
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("Generic math");
var totalInt = new Total<int>();
totalInt++;
totalInt++;
Console.WriteLine($"Total int is {totalInt.Value} after two ++");

var totalDec = new Total<decimal>();
totalDec++;
totalDec++;
Console.WriteLine($"Total decimal is {totalDec.Value} after two ++");
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("Other uses of static abstract members in interfaces");
new Dog().NumberOfLegs();
new Snake().NumberOfLegs();
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("The C# 11 compiler ensures that all fields of a struct type are initialized to their default value as part of executing a constructor");
var autoStruct = new AutoStruct();
Console.WriteLine($"AutoStruct has default values for all fields: {autoStruct.X}, {autoStruct.Name}, {autoStruct.Value}");
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("The !! null check operator");
CallWithTry(() => ClassWithChecks.ValidateParams(null));
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("Pattern matching on Char Span");
PatternMatchSpan.ShowFeature();
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("Extended nameof scope");
NameOfScope.ShowFeature();
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("UTF-8 string literals");
Utf8StringLiterals.ShowFeature();
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("Required members");
Person.ShowFeature();
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("ref fields and ref scoped variable");
ScopedRef.ShowFeature();
Console.WriteLine();

// ----------------------------------------------
Console.WriteLine("Raw string literals");
RawStringLiterals.ShowFeature();
Console.WriteLine();