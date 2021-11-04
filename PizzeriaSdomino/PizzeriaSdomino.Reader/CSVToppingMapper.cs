using CsvHelper.Configuration;
using PizzeriaSdomino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzeriaSdomino.Reader
{
    public class CSVToppingMapper:ClassMap<PizzaCSV>
    {
        public CSVToppingMapper()
        {
            Map(x => x.basePizza).Name("BasePizza");
            Map(x => x.impasto).Name("Impasto");
            Map(x => x.aggiunte).Convert(x=>myConverter(x.Row.GetField("Ingredienti")));
        }

        public List<string> myConverter(string text)
        {
            var arrayTemp = text.Split(",");
            var listTemp = new List<string>();
            for (var i=0; i< arrayTemp.Length; i++)
            {
                listTemp.Add(arrayTemp[i]);
            }
            return listTemp;
        }
    }
}
