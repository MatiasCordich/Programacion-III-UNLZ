using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoServices.Models
{
    public class Articulo
    {
        // Atributos
        public string description { get; set; }
        public double price { get; set; }

        // Constructor
        public Articulo(string description, double price)
        {
            this.description = description;
            this.price = price;
        }

    }
}
