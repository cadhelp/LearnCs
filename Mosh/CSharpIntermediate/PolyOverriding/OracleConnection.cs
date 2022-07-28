namespace PolyOverriding
{
    using System;

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
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
                Console.WriteLine("Opening an Oracle connection");
            }
            else
            {
                throw new Exception("Oracle Connection timed out before it could be opened.");
            }
        }

        public override void Close()
        {
            Console.WriteLine("Closing an Oracle connection");
        }
    }
}