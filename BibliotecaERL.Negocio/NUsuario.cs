﻿using BibliotecaERL.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaERL.Entidades;

namespace BibliotecaERL.Negocio
{
    public class NUsuario
    {
       public static DataTable Login(string Correo, string Clave)
        {
            Dusuario Datos = new Dusuario();
            return Datos.Login(Correo, Clave);
        }
    }
}