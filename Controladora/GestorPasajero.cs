using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class GestorPasajero
    {
        private static GestorPasajero instancia;

        public static GestorPasajero Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new GestorPasajero();
                }
                return instancia;
            }
        }
        private GestorPasajero() { }
        public string AgregarPasajero(Pasajero nuevoPasajero, RepositorioPasajero repositorioPasajero)
        {
            var existePasajero = repositorioPasajero.Pasajeros.FirstOrDefault(a => a.Dni == nuevoPasajero.Dni);
            if (existePasajero == null)
            {
                repositorioPasajero.Agregar(nuevoPasajero);
                return "Pasajero agregado";
            }
            else
            {
                return "El pasajero ya existe!!";
            }
        }

        public string EliminarPasajero(Pasajero unPasajero, RepositorioPasajero repositorioPasajero)
        {
            repositorioPasajero.Eliminar(unPasajero);
            return "Pasajero eliminado";
        }

        public string ModificarPasajero(Pasajero unPasajero, RepositorioPasajero repositorioPasajero)
        {
            repositorioPasajero.Modificar(unPasajero);
            return "Pasajero modificado";
        }
    }
}
