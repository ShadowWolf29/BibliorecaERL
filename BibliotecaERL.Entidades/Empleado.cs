using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaERL.Entidades
{
    public class Empleado
    {
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int id_tipo_usuario { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }
    }
}
