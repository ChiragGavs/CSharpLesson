using Microsoft.Data.SqlClient;

namespace MovieApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"Data Source=200411LTP2714\SQLEXPRESS;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
