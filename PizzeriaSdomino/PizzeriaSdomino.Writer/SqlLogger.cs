using System.Linq;
using PizzeriaSdomino.Model;
using PizzeriaSdomino.Reader;
using System.Data.SqlClient;
using System;
using Microsoft.Extensions.Configuration;

namespace PizzeriaSdomino.Writer
{
    public class SqlLogger : AuditDecorator
    {
        private readonly IConfiguration _configuration;
        public SqlLogger(IAudit logger, IConfiguration configuration) : base(logger)
        {
            _configuration = configuration;
        }
        public override void Log(Scontrino ordine)
        {
            base.Log(ordine);
            using var connection = new SqlConnection(_configuration["connection"]);
            connection.Open();
            var query = @"INSERT INTO dbo.Scontrino (Totale) VALUES (@totale) SELECT SCOPE_IDENTITY();";
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@totale", ordine.listaPizze.Sum(x => x.GetPrezzo()));
            var idscontrino = Convert.ToInt32(command.ExecuteScalar());
            query = @"INSERT INTO dbo.Pizza (Base,Impasto,Aggiunta,Prezzo,IdScontrino) VALUES (@base,@impasto,@aggiunta,@prezzo,@idscontrino)";
            
            foreach (var pizza in ordine.listaPizze)
            {
                using var commandSecond = new SqlCommand(query, connection);
                commandSecond.Parameters.AddWithValue("@base", pizza.basePizza.descrizione);
                commandSecond.Parameters.AddWithValue("@impasto", pizza.impastoPizza.descrizione);
                commandSecond.Parameters.AddWithValue("@aggiunta", String.Concat(pizza.aggiuntePizza.Select(x => $", {x.descrizione}")));
                commandSecond.Parameters.AddWithValue("@prezzo", pizza.GetPrezzo());
                commandSecond.Parameters.AddWithValue("@idscontrino", idscontrino);
                commandSecond.ExecuteNonQuery();
            }
        }
    }
}
