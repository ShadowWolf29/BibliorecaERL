using BibliotecaERL.Datos;
using BibliotecaERL.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaERL.Negocio
{
    public class Nprestamo
    {

        public static string Insertar(int id_libro, int id_empleado, DateTime fecha_prestamo, DateTime fecha_devolucion)
        {
            DPrestamo Datos = new DPrestamo();
            Prestamo Obj = new Prestamo();
            Obj.id_libro = id_libro;
            Obj.id_empleado = id_empleado;
            Obj.fecha_prestamo = fecha_prestamo;
            Obj.fecha_devolucion = fecha_devolucion;
            return Datos.Insertar(Obj);
        }

        public static DataTable BuscarPrestamos(string Valor)
        {

            DPrestamo Datos = new DPrestamo();
            return Datos.Buscar(Valor);
        }

        public static string ActualizarPrestamo(int Id_prestamo)
        {
            DPrestamo Datos = new DPrestamo();
            Prestamo Obj = new Prestamo();
            return Datos.ActualizarEstado(Id_prestamo);
        }
    }
}
