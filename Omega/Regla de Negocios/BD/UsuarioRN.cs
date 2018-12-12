using System.Collections.Generic;
using Acceso_a_base_de_datos;
using Entidades;
using System.Linq;
using System.Data;

namespace Regla_de_Negocios.BD
{
    public class UsuarioRN
    {
        public List<Usuario> Usuarios(Usuario u)
        {
            var conexionExcel = new ConexionExcel();
            var excel = conexionExcel.Conexion;

            var usuarios = (from p in excel.Worksheet<Usuario>("Usuario")
                            where p.NombreUsuario == u.NombreUsuario
                            select p).ToList();

            return usuarios;
        }

        //public Boolean InsertarBloqueo(Usuario u)
        //{
        //    var listaParametros = new List<SqlParameter>();
        //    var fecha = new SqlParameter
        //    {
        //        ParameterName = "@fecha",
        //        SqlDbType = SqlDbType.DateTime,
        //        Value = u.FechaBloqueo
        //    };
        //    var id = new SqlParameter
        //    {
        //        ParameterName = "@id",
        //        SqlDbType = SqlDbType.Int,
        //        Value = u.IdUsuario
        //    };
        //    listaParametros.Add(fecha);
        //    listaParametros.Add(id);
        //    string stored = "sp_InsertarBloqueo";
        //    return comandos.EjecutarStore(stored, listaParametros);
        //}

        public DataTable ListarUsuarios()
        {
            DataTable dataTable = new DataTable();
            var excel = new ConexionExcel().Conexion;
            var usuarios = (from p in excel.Worksheet<Usuario>("Usuario")
                            select p).ToList();

            dataTable.Columns.Add("Id",typeof(int));
            dataTable.Columns.Add("Nombre",typeof(string));

            foreach (var u in usuarios)
            {
                dataTable.Rows.Add(u.IdUsuario,u.NombreUsuario);
            }

            return dataTable;
        }
        //public Boolean AltaUsuario(Usuario u)
        //{
        //    var listaParametros = new List<SqlParameter>();
        //    var usuario = new SqlParameter
        //    {
        //        ParameterName = "@nombre",
        //        Value = u.NombreUsuario,
        //        SqlDbType = SqlDbType.VarChar
        //    };
        //    var contraseña = new SqlParameter
        //    {
        //        ParameterName = "@contraseña",
        //        Value = Encriptacion.Encriptar(u.Contraseña),
        //        SqlDbType = SqlDbType.VarChar
        //    };
        //    listaParametros.Add(usuario);
        //    listaParametros.Add(contraseña);
        //    string stored = "sp_InsertarUsuario";
        //    return comandos.EjecutarStore(stored, listaParametros);
        //}

        //public Boolean BajaUsuario(Usuario u)
        //{
        //    var listaParametros = new List<SqlParameter>();
        //    var id = new SqlParameter
        //    {
        //        ParameterName = "@id",
        //        Value = u.IdUsuario,
        //        SqlDbType = SqlDbType.Int
        //    };
        //    listaParametros.Add(id);
        //    string stored = "sp_EliminarUsuario";
        //    return comandos.EjecutarStore(stored, listaParametros);
        //}

        //public Boolean ModificacionUsuario(Usuario u)
        //{
        //    var listaParametros = new List<SqlParameter>();
        //    var id = new SqlParameter
        //    {
        //        ParameterName = "@id",
        //        Value = u.IdUsuario,
        //        SqlDbType = SqlDbType.Int
        //    };
        //    var contraseña = new SqlParameter
        //    {
        //        ParameterName = "@contraseña",
        //        Value = Encriptacion.Encriptar(u.Contraseña),
        //        SqlDbType = SqlDbType.VarChar
        //    };

        //    listaParametros.Add(id);
        //    listaParametros.Add(contraseña);
        //    string stored = "sp_ModificarUsuario";
        //    return comandos.EjecutarStore(stored, listaParametros);
        //}

    }
}
