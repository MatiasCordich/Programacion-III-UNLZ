using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProductosService.Models
{
    public class Producto
    {
        //------ Modelo - Atributos ------//
        public long ProductoID { get; set; }    
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaID { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }

        //------ Modelo - Constructor ------//
        public Producto(string codigo, string description, decimal valor, int cantidad)
        {
            Codigo = codigo;
            Descripcion = description;
            Valor = valor;
            Cantidad = cantidad;
        }

        //------ Modelo - Constructor para manejar la DDBB ------//
        public Producto() { }
    }
}
