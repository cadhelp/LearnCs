namespace PolyOverriding
{
    using System;

    public class DbCommand
    {
        private readonly string _instruction;

        private readonly DbConnection _dBConnection;
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
            {
                throw new ArgumentNullException(nameof(dbConnection),"Database cannot be null.");
            }

            if (string.IsNullOrEmpty(instruction))
            {
                throw new ArgumentNullException(nameof(instruction),"Instructions cannot be null, whitespace, or empty.");
            }

            this._instruction = instruction;

            this._dBConnection = dbConnection;
        }

        public void Execute()
        {
            this._dBConnection.Open();
            Console.WriteLine($"Executing: {this._instruction}");
            this._dBConnection.Close();
        }
        
    }
}