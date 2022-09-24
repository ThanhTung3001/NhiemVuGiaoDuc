



using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace HueCitApp.Connection
{
    public class ConnectionDb : IConnectionDb
    {
       var logger = services.GetRequiredService<ILogger<Program>>();
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        private SqlConnection con = null;
        private SqlTransaction transaction = null;
        private ConnectionDb(IConfiguration configuration)
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
              
                logger.LogError(ex, "co gi do sai sai roi");
                return null;

            }

        }



    }
}