using LinqToExcel;
using System.Configuration;

namespace Acceso_a_base_de_datos
{
    public class ConexionExcel
    {
        public ExcelQueryFactory Conexion = new ExcelQueryFactory(ConfigurationManager.AppSettings["Excel"].ToString())
        {
            DatabaseEngine = LinqToExcel.Domain.DatabaseEngine.Ace,
            TrimSpaces = LinqToExcel.Query.TrimSpacesType.Both,
            UsePersistentConnection = true,
            ReadOnly = true
        };
    }
}
