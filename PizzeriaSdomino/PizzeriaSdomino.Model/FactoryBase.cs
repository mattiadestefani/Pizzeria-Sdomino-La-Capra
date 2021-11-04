using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Model
{
    public static class FactoryBase
    {
        public static Base BaseBuilder(int idBase) => idBase switch
        {
            0 => new Margherita(),
            1 => new Pepperoni(),
            2 => new Napoletana(),
            _ => new Margherita()
        };
    }
}