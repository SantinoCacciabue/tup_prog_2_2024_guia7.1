using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class RangoDniIncorrectoException:ApplicationException
    {
        public RangoDniIncorrectoException():base("Rango dni inválido") { }
        public RangoDniIncorrectoException(string message):base(message) { }
        public RangoDniIncorrectoException(string message, Exception ex):base(message, ex) { }
    }
}
