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
        public long id { get; private set; }
        public string description { get; set; }
        public decimal price { get; set; }

        // Constructor
        public Articulo(long id, string description, decimal price)
        {
            this.id = id;
            this.description = description;
            this.price = price;
        }

        


    }
}
