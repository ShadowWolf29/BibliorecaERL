using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BibliotecaERL.Entidades;
using System.Data.SqlClient;

namespace BibliotecaERL.Datos
    
{
    public class DLibro
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_listar",SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Listar_disponible()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_listar_disponible", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Buscar_disponible(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_buscar_disponible", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Insertar(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@num_ejemplares", SqlDbType.Int).Value = Obj.num_ejemplares;
                Comando.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.isbn;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@autores", SqlDbType.VarChar).Value = Obj.autores;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.Int).Value = Obj.anio_edicion;
                Comando.Parameters.Add("@num_edicion", SqlDbType.Int).Value = Obj.num_edicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.materia;
                Comando.Parameters.Add("@num_paginas", SqlDbType.Int).Value = Obj.num_paginas;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.editorial;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puedo insertar";
            }
            catch(Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_libro", SqlDbType.Int).Value = Obj.id_libro;
                Comando.Parameters.Add("@num_ejemplares", SqlDbType.Int).Value = Obj.num_ejemplares;
                Comando.Parameters.Add("@isbn", SqlDbType.VarChar).Value = Obj.isbn;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.titulo;
                Comando.Parameters.Add("@autores", SqlDbType.VarChar).Value = Obj.autores;
                Comando.Parameters.Add("@anio_edicion", SqlDbType.Int).Value = Obj.anio_edicion;
                Comando.Parameters.Add("@num_edicion", SqlDbType.Int).Value = Obj.num_edicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.materia;
                Comando.Parameters.Add("@num_paginas", SqlDbType.Int).Value = Obj.num_paginas;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.descripcion;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.editorial;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puedo actualizar";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string ActualizarCantidad(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ejemplares_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_libro", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puedo actualizar";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }


        public string ActualizarEjemplares(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ejemplares_devolver", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_libro", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puedo actualizar";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libros_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_libro", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
