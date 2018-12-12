using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Acceso_a_base_de_datos;
using Entidades;
using System.Linq;

namespace Regla_de_Negocios.BD
{
    public class JuegoRN
    {
        Comandos comandos = new Comandos();

        public IList<Imagen> ListaImagenes()
        {
            var conexionExcel = new ConexionExcel();
            var excel = conexionExcel.Conexion;

            return (from p in excel.Worksheet<Imagen>("Imagen")
                    select p).ToList();
        }

        public DataTable TablaMovimientos()
        {
            DataTable dataTable = new DataTable();
            var excel = new ConexionExcel().Conexion;

            var movimiento = (from p in excel.Worksheet<Movimiento>("Movimiento")
                              select p).ToList();
            var juego = (from p in excel.Worksheet<Juego>("Juego")
                         select p).ToList();

            var dificultad = (from p in excel.Worksheet<Dificultad>("Dificultad")
                              select p).ToList();

            var movimientos = (from d in dificultad
                               join m in movimiento on d.IdDificultad equals m.IdDificultad
                               join j in juego on m.IdJuego equals j.IdJuego
                               select new
                               {
                                   Jugador = m.Jugador,
                                   Puntuación = m.Puntuacion,
                                   Juego = j.NombreJuego,
                                   Dificultad = d.NombreDificultad,
                                   Fecha = m.Fecha
                               }).ToList();


            dataTable.Columns.Add("Jugador", typeof(string));
            dataTable.Columns.Add("Puntuación", typeof(int));
            dataTable.Columns.Add("Juego", typeof(string));
            dataTable.Columns.Add("Dificultad", typeof(string));
            dataTable.Columns.Add("Fecha", typeof(DateTime));

            foreach (var m in movimientos)
            {
                dataTable.Rows.Add(m.Jugador,m.Puntuación,m.Juego,m.Dificultad,m.Fecha);
            }

            return dataTable;
        }

        public Boolean NuevoMovimiento(Movimiento m) //modificar para excel
        {
            var listaParametros = new List<SqlParameter>();
            var puntuacion = new SqlParameter
            {
                ParameterName = "@puntuacion",
                Value = m.Puntuacion,
                SqlDbType = SqlDbType.Int
            };
            var fecha = new SqlParameter
            {
                ParameterName = "@fecha",
                Value = m.Fecha,
                SqlDbType = SqlDbType.DateTime
            };
            var jugador = new SqlParameter
            {
                ParameterName = "@jugador",
                Value = Movimiento.JugadorMovimiento,
                SqlDbType = SqlDbType.VarChar
            };
            var juego = new SqlParameter
            {
                ParameterName = "@idJuego",
                Value = m.IdJuego,
                SqlDbType = SqlDbType.Int
            };
            var dificultad = new SqlParameter
            {
                ParameterName = "@idDificultad",
                Value = m.IdDificultad,
                SqlDbType = SqlDbType.Int
            };
            listaParametros.Add(puntuacion);
            listaParametros.Add(fecha);
            listaParametros.Add(jugador);
            listaParametros.Add(juego);
            listaParametros.Add(dificultad);
            string stored = "sp_InsertarMovimiento";
            return comandos.EjecutarStore(stored, listaParametros);
        }
    }
}
