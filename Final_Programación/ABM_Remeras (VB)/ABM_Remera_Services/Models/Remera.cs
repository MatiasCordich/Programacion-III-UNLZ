using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Remera_Services.Models
{
    public class Remera
    {
        // Exactamente lo mismo que en el proyecto anterior
        
        // ----- ATRIBUTOS ----- //
        public string Codigo { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public string Talle { get; set; }

        // Constructor
        public Remera(string codigo, string detalle, double precio, string talle)
        {
            Codigo = codigo;
            Detalle = detalle;
            Precio = precio;
            Talle = talle;
        }
    }
}
