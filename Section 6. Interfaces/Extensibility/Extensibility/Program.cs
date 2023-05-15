namespace Extensibility;

public class Program
{
    static void Main()
    {
        var dBMigrator = new DbMigrator(new FileLogger("F:\\Repos\\C# Learning Path\\CSharpIntermediateWithMosh\\Section 6. Interfaces\\Extensibility\\Logs\\log.txt"));
        dBMigrator.Migrate();
    }
}