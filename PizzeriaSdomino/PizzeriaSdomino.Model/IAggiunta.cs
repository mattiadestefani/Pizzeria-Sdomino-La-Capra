using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Model
{
    public interface IAggiunta
    {
        (decimal Prezzo, string Descrizione) GetAggiunta();
    }
}
