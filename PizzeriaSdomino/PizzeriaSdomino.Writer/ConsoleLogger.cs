using PizzeriaSdomino.Model;
using System;
using System.Linq;


namespace PizzeriaSdomino.Writer
{
    public class ConsoleLogger : Audit
    {
        public override void Log(Scontrino ordine)
        {
            Console.WriteLine($"Scontrino numero {ordine.idScontrino} - Elenco pizze:");
            Console.WriteLine(Environment.NewLine);
            Console.Write(String.Concat(ordine.listaPizze.Select(x => $"{ x.basePizza.descrizione} {x.impastoPizza.descrizione} {String.Concat(x.aggiuntePizza.Select(y => $", {y.descrizione}"))} prezzo {x.GetPrezzo()}{Environment.NewLine}")));
            Console.WriteLine($"Totale ordine :{ordine.listaPizze.Sum(x => x.GetPrezzo())}");
        }
    }
}
