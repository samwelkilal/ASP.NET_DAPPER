using Dapper;
using InviceGeneration.Application.RepositoryInterface;
using InviceGeneration.Domain.Entity;
using InvoiceGeneration.Infrastructure.DbConnection;
using Microsoft.Data.SqlClient; // Import Microsoft.Data.SqlClient for SqlConnection
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace InviceGeneration.Infrastructure.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly DapperDbContext _context;

        public InvoiceRepository(DapperDbContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> GetInvoice()
        {
            using (var connection = _context.GetConnection()) // Get IDbConnection from DapperDbContext
            {
                // Open the connection
                connection.Open();

                // Execute the SQL query to select all records from the Payment table
                var payments = await connection.QueryAsync<Payment>("SELECT * FROM Payments");

                // Convert the result to a list and return it
                return payments.ToList();
            }
        }
    }
}
