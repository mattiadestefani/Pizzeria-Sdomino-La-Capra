using PizzeriaSdomino.Model;
using PizzeriaSdomino.Reader;
using System;
using System.IO;
using PizzeriaSdomino.Writer;

namespace PizzeriaSdomino.Core
{
    class Program
    {
        public static string pathFile = @"C:\Users\mob10\source\repos\Pizzeria-Sdomino-La-Capra\input";
        static void Main(string[] args)
        {
            Engine();
        }

        public static void Engine()
        {
            var listOfCsv = new DirectoryInfo(pathFile);
            var writeOnConsole = new ConsoleLogger();
            var writeOnFile = new FileLogger(writeOnConsole);
            var writeOnSql = new SqlLogger(writeOnFile);
            foreach (var file in listOfCsv.GetFiles())
            {
                var scontrino = new Scontrino()
                {
                    idScontrino = Convert.ToInt32(file.Name.Split(".")[0])
                };
                scontrino.listaPizze = new CSVReader().GetOrdiniFromCSV(file.FullName);
                writeOnSql.Log(scontrino);
            }
        }
    }

}
