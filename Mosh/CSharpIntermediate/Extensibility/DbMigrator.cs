using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger) // passing in the ILogger is called dependency injection.
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            this._logger.LogInfo($"Migration started at {DateTime.Now}");
            // Above is better than just writing tot he console. Now Logger can have different methods to log to file or console.
            //Console.WriteLine($"Migration started at {DateTime.Now}");

            // Details of migrating the database

            this._logger.LogInfo($"Migration finished at {DateTime.Now}");
            //Console.WriteLine($"Migration finished at {DateTime.Now}");
        }
    }
}
