using Microsoft.Data.SqlClient;
using System;
using System.Data;


namespace InvoiceGeneration.Infrastructure.DbConnection
{
    public class DapperDbContext
    {
        private readonly string _connectionString;

        public DapperDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
