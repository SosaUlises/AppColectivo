using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioColectivo
    {
        private List<Colectivo> colectivos;
        private static RepositorioColectivo instancia;

        private RepositorioColectivo()
        {
            colectivos = new List<Colectivo>();
        }

        public static RepositorioColectivo Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new RepositorioColectivo();
                }
                return instancia;
            }
        } 

        public ReadOnlyCollection<Colectivo> Colectivos
        {
            get { return colectivos.AsReadOnly(); }
        }

        public void Agregar(Colectivo colectivo)
        {
            colectivos.Add(colectivo);
        }
        public void Eliminar(Colectivo colectivo)
        {
            colectivos.Remove(colectivo);
        }
        public void Modificar(Colectivo colectivo)
        {
            colectivos.Remove(colectivo);
            colectivos.Add(colectivo);
        }
    }
}
