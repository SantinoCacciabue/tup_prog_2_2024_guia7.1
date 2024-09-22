using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class DepartamentoVehicular
    {
        ArrayList registros = new ArrayList();
        public int CantidadRegistros
        {
            get { return registros.Count; }
        }
        public RegistroVehiculo RegistrarVehiculo(Persona p,string patente,string serie)
        {
            RegistroVehiculo nuevo = new RegistroVehiculo(patente, serie,p);
            registros.Add(nuevo);
            return nuevo;
        }
        public RegistroVehiculo VerRegistro(int i)
        {
            return registros[i] as RegistroVehiculo;
        }
    }
}
