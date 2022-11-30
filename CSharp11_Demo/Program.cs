// See https://aka.ms/new-console-template for more information
using ConsoleTools;

var menu = new ConsoleMenu(args, level: 0)
        .Add("File-scoped types", () => Widget.ShowFeature())
        .Add("Generic Math", () => GenericMath.ShowFeature())
        .Add("Static in interfaces", () => StaticInInterfaces.ShowFeature())
        .Add("Auto struct defaults", () => AutoStruct.ShowFeature())
        .Add("Null checks", () => ClassWithChecks.ShowFeature())
        .Add("Pattern Match span", () => PatternMatchSpan.ShowFeature())
        .Add("NameOf Scope", () => NameOfScope.ShowFeature())
        .Add("Utf8 string literals", () => Utf8StringLiterals.ShowFeature())
        .Add("Required members", () => Person.ShowFeature())
        .Add("Scoped ref", () => ScopedRef.ShowFeature())
        .Add("Raw string literals", () => RawStringLiterals.ShowFeature())
        .Add("Generic attributes", () => GenericAttributes.ShowFeature())
        .Add("List Patterns", () => ListPatterns.ShowFeature())
        .Add("Exit", () => Environment.Exit(0))
        .Configure(config =>
        {
            config.Selector = "--> ";
            config.EnableFilter = true;
            config.Title = "Below some of the C# 11 features";
            config.EnableWriteTitle = true;
            config.EnableBreadcrumb = true;
        });

menu.Show();
