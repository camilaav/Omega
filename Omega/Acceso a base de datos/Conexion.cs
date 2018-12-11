using System.Data.SqlClient;
using System.Configuration;

namespace Acceso_a_base_de_datos
{
    public class Conexion
    {
        public SqlConnection ObtenerDireccion()
        {
            SqlConnection cone = new SqlConnection(ConfigurationManager.AppSettings["Conexion"].ToString());
            return cone;
        }
    }
}
