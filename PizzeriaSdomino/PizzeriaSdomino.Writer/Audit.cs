using PizzeriaSdomino.Model;

namespace PizzeriaSdomino.Writer
{
    public abstract class Audit : IAudit
    {
        public abstract void Log(Scontrino ordine);
    }
}
