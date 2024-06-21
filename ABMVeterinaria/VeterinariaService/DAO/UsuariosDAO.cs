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
            string conexionURL = "server=MATIAS\\SQLEXPRESS01;Database=veterinaria_db;Integrated Security=true";

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
            string query = $"SELECT UsuarioID, NombreUsuario, Clave, Estado FROM Usuarios WHERE NombreUsuario='{nombre}' AND Clave='{clave}';";

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
                    Estado = lector.GetString(3)
                };
            }

            // Cerramos la conexion
            conexion.Close();

            // Devolvemos el resultado
            return usuarioEncontrado;
        }

        //----------------------------------- REACTIVAR USUARIO -----------------------------------
        public bool ReactivarUsuario(long id)
        {
            // Definimos la consulta SQL para hacer un SOFT DELETE

            // Hacemoes el pase de datos y valores que recibimos por parametros a la QUERY
            string query = $"UPDATE Usuarios SET Estado = 'Activo' WHERE UsuarioID = {id}";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos el texto al comando
            command.CommandText = query;

            // Ejecutamos la sentencia 
            int rowsAffected = command.ExecuteNonQuery();

            // Cerramos la conexion
            connection.Close();

            // Retornamos true si hubo cambios en las filas, false en caso contrario
            return rowsAffected > 0;
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
            comando.CommandText = "SELECT UsuarioID, NombreUsuario, Clave, Estado FROM Usuarios";

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
                    Estado= lector.GetString(3)
                };

                // Agregamos cada Usuario a la lista
                listaUsuarios.Add(usuario);
            }

            // Cerramos conexion y devolvemos la lista
            conexion.Close();

            return listaUsuarios;
        }

        //--------------- GET BY ID --------------- 
        public Usuario GetByID(long id)
        {
            // Hacemos el pase de datos y valores de newP a la QUERY
            string query = $"SELECT UsuarioID, NombreUsuario, Clave, Estado FROM Usuarios WHERE UsuarioID={id}";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand comando = conexion.CreateCommand();

            // Le agregamos el texto al comando
            comando.CommandText = query;

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer los resultados de la sentencia
            IDataReader lector = comando.ExecuteReader();

            // Definimos el producto
            Usuario usuarioEncontrado = null;

            // Si hay datos en el lector, lo volcamos al objeto productoEcontrado
            if (lector.Read())
            {
                usuarioEncontrado = new Usuario()
                {
                    UsuarioID = lector.GetInt32(0),
                    NombreUsuario = lector.GetString(1),
                    Clave = lector.GetString(2),
                    Estado = lector.GetString(3),
                };
            }

            // Una vez realizado la sentencia cerramos conexion y devolvemos el resultado
            conexion.Close();

            return usuarioEncontrado;
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

        //--------------- UPDATE ---------------
        public bool Update(long id, string nombre, string clave)
        {

            // Hacemoes el pase de datos y valores que recibimos por parametros a la QUERY
            string query = $"UPDATE Usuarios SET NombreUsuario = '{nombre}', Clave = '{clave}' WHERE UsuarioID = {id} AND Estado = 'Activo';";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos el texto al comando
            command.CommandText = query;

            // Ejecutamos la sentencia 
            int rowsAffected = command.ExecuteNonQuery();

            // Cerramos la conexion
            connection.Close();

            // Retornamos true si hubo cambios en las filas, false en caso contrario
            return rowsAffected > 0;

        }

        //--------------- DELETE ---------------
        public bool Delete(long id)
        {

            // Definimos la consulta SQL para hacer un SOFT DELETE

            // Hacemoes el pase de datos y valores que recibimos por parametros a la QUERY
            string query = $"UPDATE Usuarios SET Estado = 'Inactivo' WHERE UsuarioID = {id}";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos el texto al comando
            command.CommandText = query;

            // Ejecutamos la sentencia 
            int rowsAffected = command.ExecuteNonQuery();

            // Cerramos la conexion
            connection.Close();

            // Retornamos true si hubo cambios en las filas, false en caso contrario
            return rowsAffected > 0;

        }

    }
}
