using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Persona
    {
        private int dni;
        public int DNI
        {
            get { return dni; }
            set
            {
                try
                {                   
                    if(value < 1000000)
                    {
                        throw new RangoDniIncorrectoException();
                    }
                }
                catch(InvalidOperationException ex)
                {
                    throw new RangoDniIncorrectoException("El dni debe ser mayor a un millón", ex);
                }
                dni = value;
            }
        }
        public string Nombre { get; private set; }
        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
    }
}
