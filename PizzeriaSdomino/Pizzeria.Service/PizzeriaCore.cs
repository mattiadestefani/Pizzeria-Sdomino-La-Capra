using Microsoft.Extensions.Configuration;
using PizzeriaSdomino.Model;
using PizzeriaSdomino.Reader;
using PizzeriaSdomino.Writer;
using System;
using System.IO;

namespace PizzeriaSdomino.Service
{
    public class PizzeriaCore
    {
        private readonly IConfiguration _configuration;
        private readonly IAudit _sqlLogger;
        private readonly IReader _reader;

        public PizzeriaCore(IConfiguration configuration,IAudit sql,IReader reader)
        {
            _configuration = configuration;
            _sqlLogger = sql;
            _reader = reader;
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
                scontrino.listaPizze = _reader.GetOrdiniFromCSV(file.FullName);
                _sqlLogger.Log(scontrino);
            }
        }
    }
}
