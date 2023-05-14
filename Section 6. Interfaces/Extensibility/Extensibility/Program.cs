namespace Extensibility;

public class Program
{
    static void Main()
    {
        var dBMigrator = new DbMigrator(new ConsoleLogger());
        dBMigrator.Migrate();
    }
}
