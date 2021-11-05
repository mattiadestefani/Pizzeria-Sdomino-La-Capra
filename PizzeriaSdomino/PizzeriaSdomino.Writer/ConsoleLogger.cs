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
            Console.WriteLine($"{String.Concat(ordine.listaPizze.Select(x => x.GetPizza()), " prezzo:",ordine.listaPizze.Select(x => x.GetPrezzo()))} Totale Ordine {ordine.listaPizze.Sum(x => x.GetPrezzo())}"); 
        }
    }
}
