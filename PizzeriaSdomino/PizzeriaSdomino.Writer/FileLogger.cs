using System;
using System.IO;
using System.Linq;
using PizzeriaSdomino.Model;

namespace PizzeriaSdomino.Writer
{
    public class FileLogger : AuditDecorator
    {
        public FileLogger(Audit logger):base(logger)
        {
        }
        public override void Log(Scontrino ordine)
        {
            base.Log(ordine);
            File.WriteAllLines(String.Concat(ordine.idScontrino,".csv"), ordine.listaPizze.Select(x => $"{x.basePizza} {x.impastoPizza} {x.aggiuntePizza.Select(y => $", {y.descrizione}")} => {x.GetPrezzo()}"));
        }
    }
}
