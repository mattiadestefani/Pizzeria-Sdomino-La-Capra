using Microsoft.Extensions.Configuration;
using PizzeriaSdomino.Model;
using PizzeriaSdomino.Reader;
using PizzeriaSdomino.Writer;
using System;
using System.IO;

namespace PizzeriaSdomino.Core
{
    public class PizzeriaCore
    {
        private readonly IConfiguration _configuration;
        private readonly IAudit _sqlLogger;

        public PizzeriaCore(IConfiguration configuration,IAudit sql)
        {
            _configuration = configuration;
            _sqlLogger = sql;
        }
        public void Engine()
        {
            var directoryInfo = new DirectoryInfo(_configuration["pathnameInput"]);
            foreach (var file in directoryInfo.GetFiles())
            {
                var scontrino = new Scontrino()
                {
                    idScontrino = Convert.ToInt32(file.Name.Split(".")[0])
                };
                scontrino.listaPizze = new CSVReader().GetOrdiniFromCSV(file.FullName);
                _sqlLogger.Log(scontrino);
            }
        }
    }
}
