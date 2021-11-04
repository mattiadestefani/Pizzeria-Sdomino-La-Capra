using PizzeriaSdomino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Writer
{
    public class ConsoleLogger : Audit
    {
        public override void Log(Scontrino ordine)
        {
            
            Console.WriteLine($"Scontrino numero {ordine.idScontrino} - Elenco pizze: {String.Concat(ordine.listaPizze.Select(x=>x.basePizza), " ", ordine.listaPizze.Select(x => x.impastoPizza), " ", String.Concat(",",ordine.listaPizze.Select(x=>x.aggiuntePizza.Select(y=>y.descrizione))))}- Totale: {CalcolaPrezzo(ordine)}");
        }

        public decimal CalcolaPrezzo(Scontrino ordine)
        {
            if (ordine.listaPizze.Select(x => x.aggiuntePizza.Any(y => y.descrizione.Equals("Ananas"))))
                return 0;

            
        }
    }
}
