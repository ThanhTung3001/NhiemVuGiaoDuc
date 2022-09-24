


using System.Data.SqlClient;

namespace HueCitApp.Connection
{
    public interface IConnectionDb
    {
        public SqlConnection getConnection();
    }
}