using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Model
{
    public class Pizza
    {
        public Base basePizza;
        public Impasto impastoPizza;
        public IEnumerable<Aggiunta> aggiuntePizza;

        public decimal GetPrezzo()
        {
            decimal prezzoPizza = 0; 
            if (!aggiuntePizza.Any(x => x.descrizione.Equals("Ananas")))
            {
                prezzoPizza += basePizza.prezzo + impastoPizza.prezzo + aggiuntePizza.Sum(x=>x.prezzo);
                return prezzoPizza;
            } 
            return prezzoPizza;
        }

        public string GetPizza()=> String.Concat("Pizza " , basePizza.descrizione , " con impasto " , impastoPizza.descrizione , aggiuntePizza.Select(x => " e" + x.descrizione));
      

    }
}
