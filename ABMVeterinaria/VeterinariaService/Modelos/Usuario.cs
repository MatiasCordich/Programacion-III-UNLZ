using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.Modelos
{
    public class Usuario
    {
        // Atributos
        public long UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Estado {  get; set; }

        // Creamos el constructor de Usuario
        public Usuario(string nombreUsuario, string clave)
        {
            NombreUsuario = nombreUsuario;
            Clave = clave;
        }

        // Constructor vacio para dar de alta un usuario en la DB
        public Usuario()
        {

        }
    }
}
