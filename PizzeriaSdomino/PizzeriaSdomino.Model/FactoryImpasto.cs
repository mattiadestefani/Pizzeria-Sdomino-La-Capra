using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Model
{
    public static class FactoryImpasto
    {
        public static IImpasto ImpastoBuilder(int impasto) => impasto switch
        {
            0 => new Normale(),
            1 => new Integrale(),
            _ => new Normale()
        };
    }
}
