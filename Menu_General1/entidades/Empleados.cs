using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_General1.Entidades
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }

        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public int IdGenero { get; set; }
        public int IdProfesion { get; set; }
        public int IdDistrito { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }

        public string DireccionActual { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }

        public string Correo1 { get; set; }
        public string Correo2 { get; set; }

        public string Observaciones { get; set; }

        public bool Estado { get; set; }
    }
}
