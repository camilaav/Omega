using System.Configuration;
using System.Data.OleDb;

namespace AccesoDatos
{
    public class Conexion
    {
        public OleDbConnection ObtenerDireccion()
        {
            var cone = new OleDbConnection(ConfigurationManager.AppSettings["Conexion"].ToString());
            return cone;
        }
    }
}
