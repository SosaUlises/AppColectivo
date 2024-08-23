using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Colectivo
    {
        private string linea;
        private string patente;
        private int asientos;
        private int precioBoleto;
        private List<Boleto> boletos;

        public string Linea
        {
            get { return linea; }
            set { linea = value; }
        }

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public int Asientos
        {
            get { return asientos; }
            set { asientos = value; }
        }

        public int PrecioBoleto
        {
            get { return precioBoleto;}
            set { precioBoleto = value;}
        }

        public Colectivo()
        {
            boletos = new List<Boleto>();
        }

        public void agregarBoleto(Boleto unBoleto)
        {
            boletos.Add(unBoleto);
        }
        public ReadOnlyCollection<Boleto> Boletos
        {
            get { return boletos.AsReadOnly(); }
        }

        public override string ToString()
        {
            return $"{Linea} - {Patente}";
        }
    }
}
