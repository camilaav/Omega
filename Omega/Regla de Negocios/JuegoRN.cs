using System;
using System.Collections.Generic;
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
    }
}
