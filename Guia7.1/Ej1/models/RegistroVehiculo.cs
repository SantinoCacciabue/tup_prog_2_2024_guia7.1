using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string pat = patente.Replace("-","").Trim().ToUpper();
            Match m = Regex.Match(pat, @"^[A-Z]{3}\d{3}$");
            if (!m.Success)
            {
                throw new FormatoPatenteNoValidaException("Patente invalida");
            }
           
            
        }
        public string VerDetalle()
        {
            return $"Nombre:{propietario.Nombre}-DNI:{propietario.DNI}-Patente:{Patente}-Nro. serie:{Serie}";
        }
    }
}
