using System;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var DbMigrator = new DbMigration(new FileLogger("d://tak.txt"));
            DbMigrator.Migrate();
            Console.WriteLine("Hello World!");
        }
    }
}