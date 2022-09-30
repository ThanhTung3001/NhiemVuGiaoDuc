



using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace HueCitApp.Connection
{
    public class ConnectionDb : IConnectionDb
    {
      
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        private SqlConnection con = null;
        private SqlTransaction transaction = null;
        public ConnectionDb(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
         

        }

        public SqlConnection getConnection()
        {
            try
            {
                return new SqlConnection(_connectionString);
            }
            catch (System.Exception ex)
            {
              
         
                return null;

            }

        }



    }
}