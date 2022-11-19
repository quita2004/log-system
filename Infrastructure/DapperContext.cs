﻿using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace Infrastructure
{
    public class DapperContext
    {
        private readonly string? _connectionString;

        public DapperContext(IConfiguration configuration) => _connectionString = configuration.GetConnectionString("SqlConnection");
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
