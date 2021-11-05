using System;
using System.Data.SqlClient;

namespace PizzeriaSdomino.Reader
{
    public class SqlReader : IReader
    {
        public int GetLastOrder()
        {
            using var connection = Connection.GetConnection();
            connection.Open();
            var sql = @"SELECT TOP 1 IdScontrino FROM Scontrini ORDER BY ASC";
            using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            if (!reader.Read())
                return Convert.ToInt32(reader["IdScontrino"]);
            return 0;
        }
    }
}
