using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class FormatoPatenteNoValidaException : ApplicationException
    {
        public FormatoPatenteNoValidaException() : base("Formato de patente no válida") { }
        public FormatoPatenteNoValidaException(string message) : base(message) { }
        public FormatoPatenteNoValidaException(string message, Exception e):base(message, e) { }

    }
}
