using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pasajero
    {
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime fechaNacimiento;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - fechaNacimiento.Year;

                // Verifica si el cumpleaños ya pasó en el año actual
                if (DateTime.Today < fechaNacimiento.AddYears(edad))
                {
                    edad--;
                }

                return edad;
            }
        }
        public override string ToString()
        {
            return $"{Nombre} - {Dni}";
        }

    }
}
