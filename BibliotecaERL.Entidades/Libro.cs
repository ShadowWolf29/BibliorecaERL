using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaERL.Entidades
{
    public class Libro
    {
        public int id_libro { get; set; }
        public int num_ejemplares { get; set; }
        public string isbn { get; set; }
        public string titulo { get; set; }
        public string autores { get; set; }
        public int anio_edicion { get; set; }
        public int num_edicion { get; set; }
        public string pais { get; set; }
        public string idioma { get; set; }
        public string materia { get; set; }
        public int num_paginas { get; set; }
        public string ubicacion { get; set; }
        public string descripcion { get; set; }
        public string editorial { get; set; }

    }
}
