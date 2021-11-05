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
            File.WriteAllLines(@"C:\Users\mob10\source\repos\Pizzeria-Sdomino-La-Capra\output\"+ordine.idScontrino+".csv", ordine.listaPizze.Select(x => $"{x.basePizza.descrizione} {x.impastoPizza.descrizione}{String.Concat(x.aggiuntePizza.Select(y => $", {y.descrizione}"))} => {x.GetPrezzo()}"));
            File.AppendAllText(@"C:\Users\mob10\source\repos\Pizzeria-Sdomino-La-Capra\output\" +ordine.idScontrino + ".csv",$"Totale ordine : {ordine.listaPizze.Sum(x => x.GetPrezzo())}");
        }
    }
}
