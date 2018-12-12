using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Acceso_a_base_de_datos;
using Entidades;

namespace Regla_de_Negocios
{
    public class JuegoRN
    {
        Comandos comandos = new Comandos();

        public Boolean NuevoMovimiento(Movimiento m)
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
