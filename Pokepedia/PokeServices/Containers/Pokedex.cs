using PokeServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Containers
{
    public class Pokedex
    { 
        // Atributos
        private readonly List<Pokemon> listaPokemones; // Usamos "readonly" porque no queremos que nadie externo cmabie nuestra lista

        // Constructor
        public Pokedex()
        {
            this.listaPokemones = new List<Pokemon>();
        }

        /// <summary>
        /// Buscar un Pokemon por su ID
        /// </summary>
        /// <param name="numeroBuscado">Recibe un numero de tipo long</param>
        /// <returns>Devuelve un Pokemon o null</returns>
        public Pokemon buscarPorNumero(long numeroBuscado)
        {
            // Premisa, seteo una variable en null
            Pokemon pokemonEncontrado = null;

            // Recorremos la lista
            foreach (Pokemon pokemon in listaPokemones)
            {
                if(pokemon.pokemonID == numeroBuscado)
                {
                    // Si el ID del pokemon de turno es igual al numero de ID entonces pokemonEncontrado tendra el valor de ese pokemon encontrado
                    pokemonEncontrado = pokemon;
                    break;
                }
            }

            // Devuelvo el resultado obtenido
            return pokemonEncontrado;
        }

        /// <summary>
        /// Validar la existencia de un pokemon por su numero de ID
        /// </summary>
        /// <param name="numeroBuscado">Recibe un numeero de tipo long</param>
        /// <returns>Retorna un booleano</returns>
        public bool existePorNumero(long numeroBuscado)
        {
            // Variable booleana
            // Llamo a la funcion creada buscarPorNumero y le paso numeroBuscado
            // La funcion puede devolver un Pokemon o null y la compara con null
            // Si trae un Pokemon entones es true porque es distinto de null, si trae un null entonces es false no existe el null != null
            bool existe = this.buscarPorNumero(numeroBuscado) != null;

            return existe;
        }

        /// <summary>
        /// Agregar un pokemon a la lista mediante validacion
        /// </summary>
        /// <param name="pokemon">Recibe un objeto de tipo Pokemon</param>
        /// <returns>De vuelve un valor booleano de mi resultado de la accion</returns>
        public bool agregarPokemon(Pokemon pokemon)
        {
            // Guardo en una variable booleana el resultado de la validacion mediante la funcion existePorNumero()
            bool seAgrega = !this.existePorNumero(pokemon.pokemonID);

            // Si existePorNumero devuelve TRUE, quiere decir que hay un pokemon, al setear con el NOT (!) pasa a FALSE por ende no se agrega
            // Si existePorNumero devuelve FALSE, quiere decir que NO hay un pokemon, al setear con el NOT (!) pasa a TRUE por ende se agrega

            // Valido el resultado de la variable seAgrega
            if (seAgrega)
            {
                this.listaPokemones.Add(pokemon);
            }

            // Devuelvo el resultado de la funcion
            return seAgrega;
        }

        /// <summary>
        /// Listar la lista de pokemones
        /// </summary>
        /// <returns>Devuelve una COPIA de la lista de pokemones</returns>
        public List<Pokemon> getPokemones()
        {
            // Vamos a crear una copia porque no queremos devolver nuestra lista original para evitar que sea modificada por un agente externo
            List<Pokemon> listaCopia = new List<Pokemon>(this.listaPokemones);

            // Devolvemos la copa
            return listaCopia;
        }
    }   
}
