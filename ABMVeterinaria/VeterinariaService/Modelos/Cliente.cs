using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.Modelos
{
    public class Cliente
    {
        // Atributos
        public long ClienteID { get; set; }
        public string Nombre { get; set; }
        public long DNI { get; set; }
        public string Estado { get; set; }

        // Creamos el constructor de Cliente
        public Cliente(string nombre, long dni)
        {
            Nombre = nombre;
            DNI = dni;
        }

        // Constructor vacio para dar de alta un Cliente desde DB
        public Cliente()
        {

        }

    }
}
