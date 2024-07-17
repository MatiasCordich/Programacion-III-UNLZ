using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Remeras.Models
{
    public class Remera
    {
        // ----- ATRIBUTOS ----- //
        public string Codigo { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public string Talle { get; set; }

        public Remera(string codigo, string detalle, double precio, string talle)
        {
            Codigo = codigo;
            Detalle = detalle;
            Precio = precio;
            Talle = talle;
        }
    }


}
