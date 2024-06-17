using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.Modelos
{
    public class Especie
    {
        // Atributos
        public long EspecieID { get; set; }
        public string NombreEspecie { get; set; }
        public int EdadMadurez { get; set; }
        public decimal PesoPromedio { get; set; }

        // Creamos el constructor de Especie
        public Especie(string nombreEspecie, int edadMadurez, decimal pesoPromedio)
        {
            NombreEspecie = nombreEspecie;
            EdadMadurez = edadMadurez;
            PesoPromedio = pesoPromedio;
        }

        // Constructor vacio para dar de alta una Especie desde DB
        public Especie()
        {

        }
    }
}
