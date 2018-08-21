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
            var usuario = new SqlParameter();
            usuario.ParameterName = "@nombre";
            usuario.SqlDbType = SqlDbType.VarChar;
            usuario.Value = u.NombreUsuario; 
            listaparametros.Add(usuario);
            string stored = "sp_BuscarUsuarios";
            SqlDataReader reader = comandos.EjecutarReader(stored, listaparametros);
            while (reader.Read())
            {
                Usuario.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                Usuario.NombreUsuario =  reader["NombreUsuario"].ToString();
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
            var fecha = new SqlParameter();
            fecha.ParameterName = "@fecha";
            fecha.SqlDbType = SqlDbType.DateTime;
            fecha.Value = u.FechaBloqueo;
            listaParametros.Add(fecha);
            var id = new SqlParameter();
            id.ParameterName = "@id";
            id.DbType = DbType.Int32;
            id.Value = u.IdUsuario;
            listaParametros.Add(id);
            string stored = "sp_InsertarBloqueo";
            return comandos.EjecutarStore(stored, listaParametros);
        }
    }
}
