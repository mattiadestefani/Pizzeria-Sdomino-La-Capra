using PizzeriaSdomino.Model;
using System;

namespace PizzeriaSdomino.Writer
{
    public interface IAudit
    {
        void Log(Scontrino ordine);
    }
}
