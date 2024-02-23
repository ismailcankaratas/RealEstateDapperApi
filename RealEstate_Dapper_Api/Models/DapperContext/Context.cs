using Microsoft.Data.SqlClient;
using System.Data;

namespace RealEstate_Dapper_Api.Models.DapperContext
{
    public class Context
    {
        private readonly IConfiguration _configration;
        private readonly string _connectionString;

        public Context(IConfiguration configration)
        {
            _configration = configration;
            _connectionString = _configration.GetConnectionString("connection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

    }
}
