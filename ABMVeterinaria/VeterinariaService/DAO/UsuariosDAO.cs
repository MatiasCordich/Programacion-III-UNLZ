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
        //----------------------------------- PREPARAR CONEXION -----------------------------------
        private IDbConnection PrepararConexion()
        {
            string conexionURL = "";

            SqlConnection conexion = new SqlConnection(conexionURL);

            conexion.Open();

            return conexion;
        }

        //----------------------------------- VALIDAR EXISTENCIA USUARIO LOGIN -----------------------------------
        public Usuario GetUsuarioLogin(string nombre, string clave)
        {

            // Definimos el Usuario
            Usuario usuarioEncontrado = null;

            // Hacemos el pase de datos y valores de newP a la QUERY
            string query = $"SELECT UsuarioID, NombreUsuario, Clave FROM Usuarios WHERE NombreUsuario='{nombre}' AND Clave='{clave}';";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand comando = conexion.CreateCommand();

            // Le agregamos el texto al comando
            comando.CommandText = query;

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer los resultados de la sentencia
            IDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                usuarioEncontrado = new Usuario()
                {
                    UsuarioID = lector.GetInt32(0),
                    NombreUsuario = lector.GetString(1),
                    Clave = lector.GetString(2),
                };
            }

            // Cerramos la conexion
            conexion.Close();

            // Devolvemos el resultado
            return usuarioEncontrado;
        }

        //----------------------------------- FUNCIONES DAO  -----------------------------------

        //--------------- GET ALL --------------- 
        public List<Usuario> GetAll()
        {
            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand comando = conexion.CreateCommand();

            // Le agregamos texto al comando
            comando.CommandText = "SELECT UsuarioID, NombreUsuario, Clave FROM Usuarios";

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer todo de nuestra tabla
            IDataReader lector = comando.ExecuteReader();

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
                    Clave = lector.GetString(2),
                };

                // Agregamos cada Usuario a la lista
                  listaUsuarios.Add(usuario);
            }

            // Cerramos conexion y devolvemos la lista
            conexion.Close();

            return listaUsuarios;
        }

        //--------------- INSERT --------------- 
        public bool Insert(Usuario nuevoU)
        {

            // Creamos la query
            string query = $"INSERT INTO Usuarios (NombreUsuario, Clave) VALUES ('{nuevoU.NombreUsuario}', '{nuevoU.Clave}');";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand comando = conexion.CreateCommand();

            // Le agregamos el texto al comando
            comando.CommandText = query;

            // Ejecutamos el comando
            int filasAfectadas = comando.ExecuteNonQuery();

            // Cerramos la conexion
            conexion.Close();

            // Retornamos el valor del comando ejecutado
            return filasAfectadas > 0;
        }

    }
}
