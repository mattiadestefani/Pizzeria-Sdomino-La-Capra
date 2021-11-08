using CsvHelper.Configuration;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using PizzeriaSdomino.Model;

namespace PizzeriaSdomino.Reader
{
    public class CSVReader : IReader
    {
        public IEnumerable<Pizza> GetOrdiniFromCSV(string pathname)
        {
            var configCSV = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
            configCSV.HasHeaderRecord = true;
            configCSV.Delimiter = ";";
            using var streamreader = new StreamReader(pathname);
            using (var csvreader = new CsvReader(streamreader, configCSV))
            {
                csvreader.Context.RegisterClassMap<CSVToppingMapper>();
                foreach (var row in csvreader.GetRecords<Pizza>())
                {
                    yield return row;
                }
            }
        } 
    }
}
