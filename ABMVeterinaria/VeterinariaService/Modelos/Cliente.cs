using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.Modelos
{
    public class Cliente
    {
        //--------------- ATRIBUTOS ---------------//
        public long ClienteID { get; set; }
        public string Nombre { get; set; }
        public long DNI { get; set; }
        public string Estado { get; set; }

        //--------------- CONSTRUCTOR CLIENTE ---------------//
        public Cliente(string nombre, long dni)
        {
            Nombre = nombre;
            DNI = dni;
        }

        //--------------- CONSTRUCTOR VACIO PARA LA DDBB ---------------//
        public Cliente()
        {

        }

    }
}
