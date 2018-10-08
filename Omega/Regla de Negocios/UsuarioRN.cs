using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using Acceso_a_base_de_datos;

namespace Regla_de_Negocios
{
    public class UsuarioRN
    {
        Comandos comandos = new Comandos();

        public List<Usuario> SeleccionarUsuario(Usuario u)
        {
            Usuario Usuario = new Usuario();
            List<Usuario> listaUsuario = new List<Usuario>();
            List<SqlParameter> listaparametros = new List<SqlParameter>();
            var usuario = new SqlParameter
            {
                ParameterName = "@nombre",
                SqlDbType = SqlDbType.VarChar,
                Value = u.NombreUsuario
            };
            listaparametros.Add(usuario);
            string stored = "sp_BuscarUsuarios";
            SqlDataReader reader = comandos.EjecutarReader(stored, listaparametros);
            while (reader.Read())
            {
                Usuario.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                Usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                Usuario.FechaBloqueo = DateTime.Parse(reader["FechaBloqueo"].ToString());
                Usuario.Contraseña = reader["Contraseña"].ToString();
                Usuario.Eliminado = Boolean.Parse(reader["Eliminado"].ToString());
            }
            listaUsuario.Add(Usuario);
            return listaUsuario;
        }

        public Boolean InsertarBloqueo(Usuario u)
        {
            var listaParametros = new List<SqlParameter>();
            var fecha = new SqlParameter
            {
                ParameterName = "@fecha",
                SqlDbType = SqlDbType.DateTime,
                Value = u.FechaBloqueo
            };
            var id = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Value = u.IdUsuario
            };
            listaParametros.Add(fecha);
            listaParametros.Add(id);
            string stored = "sp_InsertarBloqueo";
            return comandos.EjecutarStore(stored, listaParametros);
        }

        public Boolean AltaUsuario(Usuario u)
        {
            var listaParametros = new List<SqlParameter>();
            var usuario = new SqlParameter
            {
                ParameterName = "@nombre",
                Value = u.NombreUsuario,
                SqlDbType = SqlDbType.VarChar
            };
            var contraseña = new SqlParameter
            {
                ParameterName = "@contraseña",
                Value = Encriptacion.Encriptar(u.Contraseña),
                SqlDbType = SqlDbType.VarChar
            };
            listaParametros.Add(usuario);
            listaParametros.Add(contraseña);
            string stored = "sp_InsertarUsuario";
            return comandos.EjecutarStore(stored, listaParametros);
        }

        public Boolean BajaUsuario(Usuario u)
        {
            var listaParametros = new List<SqlParameter>();
            var id = new SqlParameter
            {
                ParameterName = "@id",
                Value = u.IdUsuario,
                SqlDbType = SqlDbType.Int
            };
            listaParametros.Add(id);
            string stored = "sp_EliminarUsuario";
            return comandos.EjecutarStore(stored, listaParametros);
        }

        public Boolean ModificacionUsuario(Usuario u)
        {
            var listaParametros = new List<SqlParameter>();
            var id = new SqlParameter
            {
                ParameterName = "@id",
                Value = u.IdUsuario,
                SqlDbType = SqlDbType.Int
            };
            var contraseña = new SqlParameter
            {
                ParameterName = "@contraseña",
                Value = Encriptacion.Encriptar(u.Contraseña),
                SqlDbType = SqlDbType.VarChar
            };

            listaParametros.Add(id);
            listaParametros.Add(contraseña);    
            string stored = "sp_ModificarUsuario";
            return comandos.EjecutarStore(stored, listaParametros);
        }

        public IList<Usuario> ListaPersonas()
        {
            var lista = new List<Usuario>();
            var stored = "st_ListarPersonas";
            var readerUsuarios = comandos.EjecutarReaderSinParametros(stored);
            while (readerUsuarios.Read())
            {
                var palabra = new Usuario
                {
                    IdUsuario = int.Parse(readerUsuarios["IdUsuario"].ToString()),
                    NombreUsuario = readerUsuarios["NombreUsuario"].ToString()
                };
                lista.Add(palabra);
            }
            return lista;
        }
    }
}
