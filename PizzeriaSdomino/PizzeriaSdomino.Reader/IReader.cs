using PizzeriaSdomino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Reader
{
    public interface IReader
    {
        IEnumerable<Pizza> GetOrdiniFromCSV(string pathname);
    }
}
