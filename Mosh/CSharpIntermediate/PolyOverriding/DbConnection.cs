namespace PolyOverriding
{
    using System;

    public abstract class DbConnection
    {

        private DateTime _startTime;
        
        private DateTime _endTime;
        
        public string ConnectionString { get; }

        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }

        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }


            this.ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}