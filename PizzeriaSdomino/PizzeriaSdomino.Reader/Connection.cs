using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Reader
{
    public static class Connection
    {
        public static SqlConnection GetConnection(string connectionString) => new SqlConnection(connectionString);
    }
}
