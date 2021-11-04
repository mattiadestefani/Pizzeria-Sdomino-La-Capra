using PizzeriaSdomino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Writer
{
    public abstract class Audit : IAudit
    {
        public abstract void Log(Scontrino ordine);
        
    }
}
