using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace ReglaDeNegocios
{
    public class JuegoRN
    {
        Comandos comandos = new Comandos();

        public IList<Imagen> ListaImagenes()
        {
            var lista = new List<Imagen>();
            var stored = "select * from Imagen";
            var readerImagen = comandos.EjecutarReaderSinParametros(stored);
            while (readerImagen.Read())
            {
                var imagen = new Imagen
                {
                    NombreImagen = readerImagen["NombreImagen"].ToString(),
                    DescripcionImagen = readerImagen["DescripcionImagen"].ToString()
                };
                lista.Add(imagen);
            }
            return lista;
        }

        public DataTable TablaMovimientos()
        {
            return comandos.Dataset("SELECT Movimiento.Jugador, Juego.NombreJuego as Juego, Dificultad.NombreDificultad as DIficultad, Movimiento.Puntuacion, Movimiento.Fecha FROM(Juego INNER JOIN(Dificultad INNER JOIN JuegoDificultad ON Dificultad.IdDificultad = JuegoDificultad.IdDificultad) ON Juego.IdJuego = JuegoDificultad.IdJuego) INNER JOIN Movimiento ON(Juego.IdJuego = Movimiento.IdJuego) AND(Movimiento.IdDificultad = JuegoDificultad.IdDificultad) AND(Movimiento.IdJuego = JuegoDificultad.IdJuego) AND(JuegoDificultad.IdDificultad = Movimiento.IdDificultad)", "Movimiento");
        }

        public Boolean NuevoMovimiento(Movimiento m)
        {
            var listaParametros = new List<OleDbParameter>();
            var puntuacion = new OleDbParameter
            {
                ParameterName = "@puntuacion",
                Value = m.Puntuacion,
                OleDbType = OleDbType.Integer
            };
            var fecha = new OleDbParameter
            {
                ParameterName = "@fecha",
                Value = m.Fecha,
                OleDbType = OleDbType.Date
            };
            var jugador = new OleDbParameter
            {
                ParameterName = "@jugador",
                Value = Movimiento.Jugador,
                OleDbType = OleDbType.VarChar
            };
            var juego = new OleDbParameter
            {
                ParameterName = "@idJuego",
                Value = m.IdJuego,
                OleDbType = OleDbType.Integer
            };
            var dificultad = new OleDbParameter
            {
                ParameterName = "@idDificultad",
                Value = m.IdDificultad,
                OleDbType = OleDbType.Integer
            };
            listaParametros.Add(puntuacion);
            listaParametros.Add(fecha);
            listaParametros.Add(jugador);
            listaParametros.Add(juego);
            listaParametros.Add(dificultad);
            string stored = "insert into Movimiento(Puntuacion,Fecha,Jugador,IdJuego,IdDificultad) values(@puntuacion, @fecha, @jugador, @idJuego, @idDificultad)";
            return comandos.EjecutarStore(stored, listaParametros);
        }
    }
}
