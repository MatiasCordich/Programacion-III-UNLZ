using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.Modelos
{
    public class Usuario
    {
        //--------------- ATRIBUTOS ---------------//
        public long UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Estado {  get; set; }

        //--------------- CONSTRUCTOR USUARIO ---------------//
        public Usuario(string nombreUsuario, string clave)
        {
            NombreUsuario = nombreUsuario;
            Clave = clave;
        }

        //--------------- CONSTRUCTOR VACIO PARA LA DDBB ---------------//
        public Usuario()
        {

        }
    }
}
