using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Acceso_a_base_de_datos;
using Entidades;

namespace Regla_de_Negocios
{
    public class JuegoRN
    {
        Comandos comandos = new Comandos();
        public IList<Dificultad> ListaDificultades()
        {
            var lista = new List<Dificultad>();
            var stored = "sp_ListarDificultades";

            var readerDificultades = comandos.EjecutarReaderSinParametros(stored);

            while(readerDificultades.Read())
            {
                var dificultad = new Dificultad
                {
                    IdDificultad = int.Parse(readerDificultades["IdDificultad"].ToString()),
                    NombreDificultad = readerDificultades["NombreDificultad"].ToString()
                };
                lista.Add(dificultad);
            }
            return lista;
        }
        public IList<Palabras> ListaPalabras()
        {
            var lista = new List<Palabras>();
            var stored = "st_ListarPalabras";
            var readerPalabras = comandos.EjecutarReaderSinParametros(stored);
            while(readerPalabras.Read())
            {
                var palabra = new Palabras
                {
                    IdPalabra = int.Parse(readerPalabras["IdPalabra"].ToString()),
                    Palabra = readerPalabras["Palabra"].ToString()
                };
                lista.Add(palabra);
            }
            return lista;
        }
        public IList<Imagen> ListaImagenes()
        {
            var lista = new List<Imagen>();
            var stored = "sp_ListarImagen";
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
                Value = Movimiento.Jugador,
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
