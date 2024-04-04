using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarritoServices.Models
{
    // La clase debe ser public
    public class Articulo
    {
        // Atributos con sus getters y setters
        public long id { get; private set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }

        // Constructor
        public Articulo(long id, string descripcion, decimal precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        // Metodos
        [Obsolete]
        private void foo()
        {
            Console.WriteLine("Hola");
        }
    }
}
