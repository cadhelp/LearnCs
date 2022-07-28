namespace PolyOverriding
{
    using System;

    public class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            
        }

        public override void Open()
        {
            this.StartTime = DateTime.Now;
            // Do some things to open the connection
            this.EndTime = DateTime.Now;

            this.Timeout = this.EndTime - this.StartTime;

            if (this.Timeout.Seconds < 5)
            {
                Console.WriteLine("Opening an SQL connection");
            }
            else
            {
                throw new Exception("SQL Connection timed out before it could be opened.");
            }
        }

        public override void Close()
        {
            Console.WriteLine("Closing an SQL connection");
        }
    }
}