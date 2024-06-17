using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaService.Modelos;

namespace VeterinariaService.DAO
{

    public class UsuariosDAO
    {
        // Funcion para prepara la conexion
        private IDbConnection PrepararConexion()
        {
            string conexionURL = "";

            SqlConnection conexion = new SqlConnection(conexionURL);

            conexion.Open();

            return conexion;
        }

        // Funciones del DAO de Usuario
        public List<Usuario> GetAll()
        {
            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos texto al comando
            command.CommandText = "SELECT ID, NOMBRE FROM usuarios";

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer todo de nuestra tabla
            IDataReader lector = command.ExecuteReader();

            // Generamos la lista de usuarios
            List<Usuario> listaUsuarios = new List<Usuario>();

            // Recorremos la respuesta del lector
            while (lector.Read())
            {
                // Por cada dato leido del LECTOR vamos a crear nuestros objetos de tipo Prouducto
                Usuario usuario = new Usuario()
                {
                    UsuarioID = lector.GetInt32(0),
                    NombreUsuario = lector.GetString(1),
                };

                // Agregamos cada Usuario a la lista
                  listaUsuarios.Add(usuario);
            }

            // Cerramos conexion y devolvemos la lista
            connection.Close();

            return listaUsuarios;

        }

    }
}
