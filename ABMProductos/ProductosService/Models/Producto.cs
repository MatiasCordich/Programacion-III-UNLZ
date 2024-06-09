using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosService.Models
{
    public class Producto
    {
        // Atributos
        public long id { get; set; }
        public string nombre { get; set; }
        public long tipoProducto_id { get; set; }
        public decimal precio { get; set; }

        // Constructor 
        public Producto(string nombre, long tipoProducto_id, decimal precio)
        {
            this.nombre = nombre;
            this.tipoProducto_id = tipoProducto_id;
            this.precio = precio;
        }

        // Constructor para la creacion del producto en la DDBB
        public Producto()
        {
        }

        

    }
}
