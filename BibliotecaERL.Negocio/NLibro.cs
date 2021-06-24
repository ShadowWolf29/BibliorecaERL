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
    public class NLibro
    {
        public static DataTable Listar()
        {
            DLibro Datos = new DLibro();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DLibro Datos = new DLibro();
            return Datos.Buscar(Valor);
        }

        public static string Insertar(int num_ejemplares, string isbn, string titulo, string autores, int anio_edicion,
         int num_edicion, string pais, string idioma,string materia, int num_paginas, string ubicacion, string descripcion,string editorial )
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();
            Obj.num_ejemplares = num_ejemplares;
            Obj.isbn = isbn;
            Obj.titulo = titulo;
            Obj.autores = autores;
            Obj.anio_edicion = anio_edicion;
            Obj.num_edicion = num_edicion;
            Obj.pais = pais;
            Obj.idioma = idioma;
            Obj.materia = materia;
            Obj.num_paginas = num_paginas;
            Obj.ubicacion = ubicacion;
            Obj.descripcion = descripcion;
            Obj.editorial = editorial;
            return Datos.Insertar(Obj);
        }

        public static string Actualizar(int id_libro,int num_ejemplares, string isbn, string titulo, string autores, int anio_edicion,
         int num_edicion, string pais, string idioma, string materia, int num_paginas, string ubicacion, string descripcion, string editorial)
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();
            Obj.id_libro = id_libro;
            Obj.num_ejemplares = num_ejemplares;
            Obj.isbn = isbn;
            Obj.titulo = titulo;
            Obj.autores = autores;
            Obj.anio_edicion = anio_edicion;
            Obj.num_edicion = num_edicion;
            Obj.pais = pais;
            Obj.idioma = idioma;
            Obj.materia = materia;
            Obj.num_paginas = num_paginas;
            Obj.ubicacion = ubicacion;
            Obj.descripcion = descripcion;
            Obj.editorial = editorial;
            return Datos.Actualizar(Obj);
        }

        public static string Eliminar(int id_libro)
        {
            DLibro Datos = new DLibro();
            Libro Obj = new Libro();
            return Datos.Eliminar(id_libro);
        }
    }

}
