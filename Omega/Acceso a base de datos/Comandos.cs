using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Acceso_a_base_de_datos
{
    public class Comandos
    {
        Conexion cnn = new Conexion();
        public Boolean EjecutarStore(string stored, List<SqlParameter> parametros)
        {
            bool retornar = true;
            var conexion = cnn.ObtenerDireccion();
            conexion.Open();
            var comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = stored;
            try
            {
                foreach (var p in parametros)
                {
                    comando.Parameters.Add(p);
                }
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

        public SqlDataReader EjecutarReader(string stored, List<SqlParameter> parametros)
        {
            SqlConnection conexion = cnn.ObtenerDireccion();
            conexion.Open();
            var comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = stored;
            foreach (var p in parametros)
            {
                comando.Parameters.Add(p);
            }
            SqlDataReader Reader = comando.ExecuteReader();
            return Reader;
        }

        public DataTable Dataset(string stored, string nombreTabla)
        {
            DataSet dataset = new DataSet();
            SqlConnection conexion = cnn.ObtenerDireccion();
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = stored;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            adapter.Fill(dataset, nombreTabla);

            return dataset.Tables[nombreTabla];
        }
    }
}
