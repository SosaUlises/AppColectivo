using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioBoletos
    {
        private List<Boleto> boletos;
        private static RepositorioBoletos instancia;

        public static RepositorioBoletos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioBoletos();
                }
                return instancia;
            }
        }

        private RepositorioBoletos()
        {
            boletos = new List<Boleto>();
        }
        public void Agregar(Boleto boleto)
        {
            boletos.Add(boleto);
        }

        public ReadOnlyCollection<Boleto> Boletos
        {
            get { return boletos.AsReadOnly(); }
        }
    }
}
