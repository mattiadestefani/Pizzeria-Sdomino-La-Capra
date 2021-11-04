using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Model
{
    public interface IImpasto
    {
        (decimal Prezzo, string Descrizione) GetImpasto();
    }
}
