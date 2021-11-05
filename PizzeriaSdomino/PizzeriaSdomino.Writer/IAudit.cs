using PizzeriaSdomino.Model;

namespace PizzeriaSdomino.Writer
{
    public interface IAudit
    {
        void Log(Scontrino ordine);
    }
}
