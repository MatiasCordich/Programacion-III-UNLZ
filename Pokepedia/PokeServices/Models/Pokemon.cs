using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Models
{
    // Clase publica
    public class Pokemon
    {
        // Atributos
        public long pokemonID { get; }
        public string nombre { get; set; }
        public TipoPokemon tipo { get; set; }

        // Constructor
        public Pokemon(long pokemonID, string nombre, TipoPokemon tipo)
        {
            this.pokemonID = pokemonID;
            this.nombre = nombre;
            this.tipo = tipo;
        }

    }
}
