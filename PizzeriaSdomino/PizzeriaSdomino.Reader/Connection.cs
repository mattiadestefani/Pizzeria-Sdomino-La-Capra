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
        private static readonly string connectionstring = @"Server=UMANA-10-MULTI\SQLEXPRESS01; Database= PizzeriaCapra;  Trusted_Connection=True;";
        public static SqlConnection GetConnection() => new SqlConnection(connectionstring);
    }
}
