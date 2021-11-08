using System;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using PizzeriaSdomino.Model;

namespace PizzeriaSdomino.Writer
{
    public class FileLogger : AuditDecorator
    {
        private readonly IConfiguration _configuration;
        public FileLogger(IAudit logger, IConfiguration configuration):base(logger)
        {
            _configuration = configuration;
        }
        public override void Log(Scontrino ordine)
        {
            base.Log(ordine);
            File.WriteAllLines(String.Concat(_configuration["pathnameOutput"],ordine.idScontrino,".csv"), ordine.listaPizze.Select(x => $"{x.basePizza.descrizione} {x.impastoPizza.descrizione}{String.Concat(x.aggiuntePizza.Select(y => $", {y.descrizione}"))} => {x.GetPrezzo()}"));
            File.AppendAllText(String.Concat(_configuration["pathnameOutput"], ordine.idScontrino, ".csv"), $"Totale ordine : {ordine.listaPizze.Sum(x => x.GetPrezzo())}");
        }
    }
}
