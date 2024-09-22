using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class RegistroVehiculo
    {
        Persona propietario { get; set; }
        public string Patente { get;private set; }  
        public string Serie {  get;private set; }
        public RegistroVehiculo(string patente, string serie, Persona p)
        {
            Serie = serie;
            Patente = patente;
            propietario = p;
            bool pat = true;
            string caracteres = Patente.Substring(0, 3);
            for (int j = 0; j < caracteres.Length; j++)
            {
                char ch = caracteres[j];
                pat &= Char.IsLetter(ch);
            }
            caracteres = Patente.Substring(3, 3);
            for (int j = 0; j < caracteres.Length; j++)
            {
                char ch = caracteres[j];
                pat &= Char.IsDigit(ch);
            }
            try
            {              
                if (pat == false)
                {
                    throw new FormatoPatenteNoValidaException();
                }
            }
            catch(FormatException e)
            {
                throw new FormatoPatenteNoValidaException("Patente no valida", e);
            }
            
        }
        public string VerDetalle()
        {
            return $"Nombre:{propietario.Nombre}-DNI:{propietario.DNI}-Patente:{Patente}-Nro. serie:{Serie}";
        }
    }
}
