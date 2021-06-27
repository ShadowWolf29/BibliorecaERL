using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaERL.Entidades
{
    public class Prestamo
    {
        public int id_prestamo { get; set; }
        public int id_libro { get; set; }
        public int id_empleado { get; set; }
        public bool estado { get; set; }
        public DateTime fecha_prestamo { get; set; }
        public DateTime fecha_devolucion { get; set; }
    }
}
