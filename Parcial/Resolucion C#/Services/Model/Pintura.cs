using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class Pintura
    {
        // Atributos
        public long codigo {  get; private set; }
        public string color { get; set; }
        public double litros { get; set; }

        // Constructor
        public Pintura(long codigo, string color, double litros)
        {
            this.codigo = codigo;
            this.color = color;
            this.litros = litros;
        }
    }
}
