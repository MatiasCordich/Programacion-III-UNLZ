using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosService.Models
{
    public class Categoria
    {
        //------ Modelo - Atributos ------//
        public long ID { get; set; }
        public string Nombre { get; set; }
        

        //------ Modelo - Constructor ------//
        public Categoria(string nombre)
        {
            Nombre = nombre;
        }

        //------ Modelo - Constructor para manejar la DDBB ------//
        public Categoria() { }
    }
}
