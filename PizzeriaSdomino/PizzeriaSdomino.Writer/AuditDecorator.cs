using PizzeriaSdomino.Model;

namespace PizzeriaSdomino.Writer
{
    public abstract class AuditDecorator : Audit
    {
        private readonly IAudit _audit;
        public AuditDecorator(IAudit aud)
        {
            _audit = aud;
        }
         public override void Log(Scontrino ordine)
        {
            _audit.Log(ordine);
        }
    }
}
