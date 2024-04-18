using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Models
{
    // Clase publica 
    public class TipoPokemon
    {
        // Atributos
        public string nombre { get; } // Solo quiero acceder al nombre (get), no quiero modificarlo (set)


        // Constructor
        public TipoPokemon(string nombre)
        {
            this.nombre = nombre;
        }

        // Metodos
        public override string ToString() // Utilizo el "override" porque estoy sobrescribiendo el método ToString()
        {
            return this.nombre;
        }
    }
}
