using Modelo;

namespace Controladora
{
    public class GestorColectivo
    {
        private static GestorColectivo instancia;

        public static GestorColectivo Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GestorColectivo();
                }
                return instancia;
            }
        }
        private GestorColectivo() { }

        public string VenderBoleto(Pasajero unPasajero, Colectivo unColectivo, RepositorioBoletos repositorioBoletos)
        {

            if (unColectivo.Asientos > unColectivo.Boletos.Count )
            {
                var existePasajero = unColectivo.Boletos.FirstOrDefault(a => a.Pasajero.Dni == unPasajero.Dni);
                if (existePasajero == null)
                {
                    Boleto nuevoBoleto = new Boleto();
                    nuevoBoleto.Pasajero = unPasajero;
                    nuevoBoleto.NroBoleto = unColectivo.Boletos.Count;
                    nuevoBoleto.Precio = unColectivo.PrecioBoleto;

                    repositorioBoletos.Agregar(nuevoBoleto); // Guardamos todos los boletos en repositorio
                    unColectivo.agregarBoleto(nuevoBoleto); // Guardamos ese boleto especifico en su lista del colectivo
                    return "Boleto vendido";
                }
                else
                {
                    return "Este pasajero ya cuenta con boleto!";
                }
            }
            else
            {
                return "Colectivo lleno";
            }
        }

        public string AgregarColectivo(Colectivo nuevoColectivo, RepositorioColectivo repositorioColectivo)
        {
            var existeColectivo = repositorioColectivo.Colectivos.FirstOrDefault(a => a.Patente == nuevoColectivo.Patente);
            if(existeColectivo == null)
            {
                repositorioColectivo.Agregar(nuevoColectivo);
                return "Colectivo agregado";
            }
            else
            {
                return "El colectivo ya existe!!";
            }
            
        }
        public string EliminarColectivo(Colectivo unColectivo, RepositorioColectivo repositorioColectivo)
        {
            repositorioColectivo.Eliminar(unColectivo);
            return "Colectivo eliminado";
        }

        public string ModificarColectivo(Colectivo unColectivo, RepositorioColectivo repositorioColectivo)
        {
            repositorioColectivo.Modificar(unColectivo);
            return "Colectivo modificado";
        }
    }
}
