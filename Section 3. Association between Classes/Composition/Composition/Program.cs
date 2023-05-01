namespace Composition;

public class Program
{
    
    static void Main()
    {
        var dbMigrator = new DbMigrator(new Logger());
        // or
        var logger = new Logger();
        var installer = new Installer(logger);

        dbMigrator.Migrate();
        installer.Install();
    }
}