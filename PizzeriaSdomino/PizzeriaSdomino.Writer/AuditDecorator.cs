using PizzeriaSdomino.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSdomino.Writer
{
    public abstract class AuditDecorator : Audit
    {
        private readonly Audit _audit;

        public AuditDecorator(Audit aud)
        {
            _audit = aud;
        }

        public override void Log(Scontrino ordine)
        {
            _audit.Log(ordine);
        }
    }
}
