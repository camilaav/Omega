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
            usuario.ParameterName = "@"; //agregar nombre parametro
            usuario.SqlDbType = SqlDbType.VarChar;
            usuario.Value = u.NombreUsuario; 
            listaparametros.Add(usuario);
            string stored = ""; //nombre store
            SqlDataReader reader = comandos.EjecutarReader(stored, listaparametros);
            while (reader.Read())
            {
                var contraseña = new SqlParameter();
                contraseña.ParameterName = "@"; //agregar nombre parametro
                contraseña.SqlDbType = SqlDbType.VarChar;
                contraseña.Value = Encriptacion.Encriptar(u.Contraseña);
                listaparametros.Add(contraseña);
                Usuario.IdUsuario = int.Parse(reader[""].ToString());
                Usuario.NombreUsuario =  reader["Usuario"].ToString();
                Usuario.FechaBloqueo = DateTime.Parse(reader["BloqueoUsuario"].ToString());
                Usuario.Contraseña = reader["PasswordUsuario"].ToString();
                Usuario.Eliminado = Boolean.Parse(reader[""].ToString());
            }
            listaUsuario.Add(Usuario);
            return listaUsuario;
        }

        public Boolean InsertarBloqueo(Usuario u)
        {
            var listaParametros = new List<SqlParameter>();
            var fecha = new SqlParameter();
            fecha.ParameterName = ""; //agregar nombre parametro
            fecha.SqlDbType = SqlDbType.Date;
            fecha.Value = u.FechaBloqueo;
            listaParametros.Add(fecha);
            var id = new SqlParameter();
            id.ParameterName = ""; //agregar nombre parametro
            id.DbType = DbType.Int32;
            id.Value = u.IdUsuario;
            listaParametros.Add(id);
            string stored = ""; //nombre store
            return comandos.EjecutarStore(stored, listaParametros);
        }
    }
}
