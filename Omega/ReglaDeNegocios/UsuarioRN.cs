using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace ReglaDeNegocios
{
    public class UsuarioRN
    {
        Comandos comandos = new Comandos();

        public List<Usuario> SeleccionarUsuario(Usuario u)
        {
            Usuario Usuario = new Usuario();
            List<Usuario> listaUsuario = new List<Usuario>();
            List<OleDbParameter> listaparametros = new List<OleDbParameter>();
            var usuario = new OleDbParameter
            {
                ParameterName = "@nombre",
                OleDbType = OleDbType.VarChar,
                Value = u.NombreUsuario
            };
            listaparametros.Add(usuario);
            string stored = "select IdUsuario,NombreUsuario,Contraseña,FechaBloqueo,Eliminado from Usuario where NombreUsuario = @nombre and Eliminado = 0";
            OleDbDataReader reader = comandos.EjecutarReader(stored, listaparametros);
            while (reader.Read())
            {
                Usuario.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                Usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                
                if(!string.IsNullOrEmpty(reader["FechaBloqueo"].ToString()))
                {
                    Usuario.FechaBloqueo = DateTime.Parse(reader["FechaBloqueo"].ToString());
                }
                else
                {
                    Usuario.FechaBloqueo = new DateTime();
                }
                Usuario.Contraseña = reader["Contraseña"].ToString();
                Usuario.Eliminado = Boolean.Parse(reader["Eliminado"].ToString());
            }
            listaUsuario.Add(Usuario);
            return listaUsuario;
        }

        public Boolean InsertarBloqueo(Usuario u)
        {
            var listaParametros = new List<OleDbParameter>();
            var fecha = new OleDbParameter
            {
                ParameterName = "@fecha",
                OleDbType = OleDbType.Date,
                Value = u.FechaBloqueo
            };
            var id = new OleDbParameter
            {
                ParameterName = "@id",
                OleDbType = OleDbType.Integer,
                Value = u.IdUsuario
            };
            listaParametros.Add(fecha);
            listaParametros.Add(id);
            string stored = "update Usuario set FechaBloqueo = @fecha where IdUsuario = @id";
            return comandos.EjecutarStore(stored, listaParametros);
        }

        public Boolean AltaUsuario(Usuario u)
        {
            var listaParametros = new List<OleDbParameter>();
            var usuario = new OleDbParameter
            {
                ParameterName = "@nombre",
                Value = u.NombreUsuario,
                OleDbType = OleDbType.VarChar
            };
            var contraseña = new OleDbParameter
            {
                ParameterName = "@contraseña",
                Value = Encriptacion.Encriptar(u.Contraseña),
                OleDbType = OleDbType.VarChar
            };
            listaParametros.Add(usuario);
            listaParametros.Add(contraseña);
            string stored = "insert into Usuario(NombreUsuario,Contraseña,FechaBloqueo,Eliminado) values(@nombre, @contraseña, null, 0)";
            return comandos.EjecutarStore(stored, listaParametros);
        }

        public Boolean BajaUsuario(Usuario u)
        {
            var listaParametros = new List<OleDbParameter>();
            var id = new OleDbParameter
            {
                ParameterName = "@id",
                Value = u.IdUsuario,
                OleDbType = OleDbType.Integer
            };
            listaParametros.Add(id);
            string stored = "update Usuario set Eliminado = 1 where IdUsuario = @id";
            return comandos.EjecutarStore(stored, listaParametros);
        }

        public Boolean ModificacionUsuario(Usuario u)
        {
            var listaParametros = new List<OleDbParameter>();
            var id = new OleDbParameter
            {
                ParameterName = "@id",
                Value = u.IdUsuario,
                OleDbType = OleDbType.Integer
            };
            var contraseña = new OleDbParameter
            {
                ParameterName = "@contraseña",
                Value = Encriptacion.Encriptar(u.Contraseña),
                OleDbType = OleDbType.VarChar
            };

            listaParametros.Add(id);
            listaParametros.Add(contraseña);
            string stored = "update Usuario set Contraseña = @contraseña where IdUsuario = @id";
            return comandos.EjecutarStore(stored, listaParametros);
        }

        public DataTable ListaPersonas()
        {
            var stored = "select IdUsuario as Id ,NombreUsuario as Usuario from Usuario where Eliminado = 0";
            var nombreTabla = "Usuario";
            return comandos.Dataset(stored, nombreTabla);
        }
    }
}
