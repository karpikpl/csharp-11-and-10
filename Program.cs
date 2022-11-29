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
