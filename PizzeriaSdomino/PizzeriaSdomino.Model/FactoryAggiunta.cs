using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Model
{
    public static class FactoryAggiunta
    {
        public static IAggiunta AggiuntaBuilder(int aggiunta) => aggiunta switch
        {
            0 => new Cotto(),
            1 => new Funghi(),
            2 => new Crudo(),
            3 => new Ananas(),
            _ => throw new Exception("Nessuna aggiunta rimasta")
        };
    }

    //test

}
