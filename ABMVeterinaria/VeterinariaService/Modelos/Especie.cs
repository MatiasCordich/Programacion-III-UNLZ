using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.Modelos
{
    public class Especie
    {
        //--------------- ATRIBUTOS ---------------//
        public long EspecieID { get; set; }
        public string NombreEspecie { get; set; }
        public int EdadMadurez { get; set; }
        public decimal PesoPromedio { get; set; }

        //--------------- CONSTRUCTOR ESPECIE ---------------//
        public Especie(string nombreEspecie, int edadMadurez, decimal pesoPromedio)
        {
            NombreEspecie = nombreEspecie;
            EdadMadurez = edadMadurez;
            PesoPromedio = pesoPromedio;
        }

        //--------------- CONSTRUCTOR VACIO PARA LA DDBB ---------------//
        public Especie()
        {

        }
    }
}
