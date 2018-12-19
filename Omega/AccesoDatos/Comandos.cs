using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace AccesoDatos
{
    public class Comandos
    {
        Conexion cnn = new Conexion();
        public Boolean EjecutarStore(string stored, List<OleDbParameter> parametros)
        {
            using (var conexion = cnn.ObtenerDireccion())
            {
                var retornar = false;
                conexion.Open();
                var comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = stored;
                try
                {
                    comando.Parameters.AddRange(parametros.ToArray());
                    comando.ExecuteNonQuery();
                    retornar = true;
                }
                catch (Exception)
                {
                    retornar = false;
                }
                finally
                {
                    conexion.Close();
                }
                return retornar;
            }
        }

        public OleDbDataReader EjecutarReader(string stored, List<OleDbParameter> parametros)
        {
            var conexion = cnn.ObtenerDireccion();
            conexion.Open();
            var comando = new OleDbCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = stored;
            foreach (var p in parametros)
            {
                comando.Parameters.Add(p);
            }
            var reader = comando.ExecuteReader();
            return reader;
        }

        public DataTable Dataset(string stored, string nombreTabla)
        {
            var dataset = new DataSet();
            var conexion = cnn.ObtenerDireccion();
            conexion.Open();
            var comando = new OleDbCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = stored;
            var adapter = new OleDbDataAdapter(comando);
            adapter.Fill(dataset, nombreTabla);

            return dataset.Tables[nombreTabla];
        }

        public OleDbDataReader EjecutarReaderSinParametros(string stored)
        {
            var conexion = cnn.ObtenerDireccion();
            conexion.Open();
            var comando = new OleDbCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = stored;

            var reader = comando.ExecuteReader();
            return reader;
        }
    }
}
