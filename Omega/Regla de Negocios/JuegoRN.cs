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
    }
}
