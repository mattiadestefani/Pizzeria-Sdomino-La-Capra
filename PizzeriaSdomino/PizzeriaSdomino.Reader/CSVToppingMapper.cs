using CsvHelper.Configuration;
using PizzeriaSdomino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzeriaSdomino.Reader
{
    public class CSVToppingMapper:ClassMap<Pizza>
    {
        public CSVToppingMapper()
        {
            Map(x => x.basePizza).Convert(x=>ConvertiBase(x.Row.GetField("BasePizza")));
            Map(x => x.impastoPizza).Convert(x => ConvertiImpasto(x.Row.GetField("Impasto")));
            Map(x => x.aggiuntePizza).Convert(x=>myConverter(x.Row.GetField("Ingredienti")));
        }

        private IEnumerable<Aggiunta> myConverter(string text) => text.Split(", ").Select(x => FactoryAggiunta.AggiuntaBuilder(x));
        private Base ConvertiBase(string baseName) => FactoryBase.BaseBuilder(baseName);
        private Impasto ConvertiImpasto(string impasto) => FactoryImpasto.ImpastoBuilder(impasto);


    }
}
