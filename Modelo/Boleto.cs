using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Boleto
    {
        private Pasajero pasajero;
        private int nroBoleto;
        private int precio;

        public Pasajero Pasajero
        {
            get { return pasajero; }
            set { pasajero = value; }
        }

        public int NroBoleto
        {
            get { return nroBoleto; }
            set { nroBoleto = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
