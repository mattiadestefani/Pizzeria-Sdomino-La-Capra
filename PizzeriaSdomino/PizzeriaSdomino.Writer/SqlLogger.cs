
using PizzeriaSdomino.Model;
using PizzeriaSdomino.Reader;

namespace PizzeriaSdomino.Writer
{
    public class SqlLogger : AuditDecorator
    {
        public SqlLogger(FileLogger logger) : base(logger)
        {
        }
        public override void Log(Scontrino ordine)
        {
            base.Log(ordine);
            using var connection = Connection.GetConnection(_connectionString);
            connection.Open();

        }

    }
}
