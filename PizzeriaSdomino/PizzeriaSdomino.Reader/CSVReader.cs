using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace PizzeriaSdomino.Reader
{
    public class CSVReader
    {
        public IEnumerable<PizzaCSV> GetOrdiniFromCSV(string pathname)
        {
            var configCSV = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
            configCSV.HasHeaderRecord = true;
            configCSV.Delimiter = ";";
            using var streamreader = new StreamReader(pathname);
            using (var csvreader = new CsvReader(streamreader, configCSV))
            {
                foreach (var row in csvreader.GetRecords<PizzaCSV>())
                {
                    yield return row;
                }
            }
        } 
    }
}
