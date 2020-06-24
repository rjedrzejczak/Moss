using System;

namespace Extensibility
{
    public class DbMigration
    {
        private readonly ILogger _logger;

        public DbMigration(ILogger logger)
        {
            _logger = logger;
        }
        
        public void Migrate()
        {
            _logger.LogInfo("Migrate started at " + DateTime.Now);
            
            //Some code
            _logger.LogInfo("Migrate finished at " + DateTime.Now);

        }
    }
}