using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioPasajero
    {
        private List<Pasajero> pasajeros;
        private static RepositorioPasajero instancia;

        public static RepositorioPasajero Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new RepositorioPasajero();
                }
                return instancia;
            }
        }

        private RepositorioPasajero()
        {
           pasajeros = new List<Pasajero>();
        }
        public ReadOnlyCollection<Pasajero> Pasajeros
        {
            get { return pasajeros.AsReadOnly();}
        }

        public void Agregar(Pasajero pasajero)
        {
            pasajeros.Add(pasajero);
        }
        public void Eliminar(Pasajero pasajero)
        {
            pasajeros.Remove(pasajero);
        }
        public void Modificar(Pasajero pasajero)
        {
            pasajeros.Remove(pasajero);
            pasajeros.Add(pasajero);
        }
    }
}
