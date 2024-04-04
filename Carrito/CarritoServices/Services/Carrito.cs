using CarritoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoServices.Services
{
    // La clase debe ser public
    public class Carrito
    {
        // El atributo de Carrito va a tener una lista de articulos
        private readonly List<Articulo> listado;

        // Constructor
        public Carrito()
        {
            this.listado = new List<Articulo>();
        }

        // La funcion para obtener el total
        public decimal getTotal()
        {
            // Creamos una variable acumuladora
            decimal total = 0;

            // Hacmoes un foreach de nuestro listado
            foreach (Articulo art in listado)
            {
                // Por cada articulo dame el precio (art.precio) y sumalo al total
                total += art.precio;
            }

            // Devolveme el valor de total
            return total;
        }

        // Esta funcion me agrega el articulo a lista de Carrito
        public void agregar(Articulo art)
        {
            this.listado.Add(art);
        }
    }
}
