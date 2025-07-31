using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasWinForms.Database
{
    public class SqlConnectionFactory
    {
        private static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=SistemaVendas;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
