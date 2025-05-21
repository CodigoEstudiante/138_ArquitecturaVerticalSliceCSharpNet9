using Microsoft.Data.SqlClient;

namespace DemoVerticalSlice.ContextDB;

public class ConnectionDB(IConfiguration _config)
{
    public SqlConnection GetSQL()
    {
        return new SqlConnection(_config.GetConnectionString("sqlString"));
    }

}
