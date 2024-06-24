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
    public class ClientesDAO
    {
        //----------------------------------- PREPARAR CONEXION -----------------------------------//
        private IDbConnection PrepararConexion()
        {
            string conexionURL = "server=MATIAS\\SQLEXPRESS01;Database=veterinaria_db;Integrated Security=true";

            SqlConnection conexion = new SqlConnection(conexionURL);

            conexion.Open();

            return conexion;
        }

        //----------------------------------- REACTIVAR CLIENTE -----------------------------------//
        public bool ReactivarUsuario(long ID)
        {
            // Definimos la consulta SQL para hacer un SOFT DELETE

            // Hacemoes el pase de datos y valores que recibimos por parametros a la QUERY
            string query = $"UPDATE Clientes SET Estado = 'Activo' WHERE ClienteID = {ID}";

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

        //----------------------------------- FUNCIONES DAO  -----------------------------------//

        //--------------- GET ALL ---------------// 
        public List<Cliente> GetAll()
        {
            //creamos conexion llamando a la funcion de preparar//
            IDbConnection conexion = this.PrepararConexion();

            //creamos un comando de texto//
            IDbCommand comando = conexion.CreateCommand();

            //en base a la tabla Clientes, agregamos los atributos//
            comando.CommandText = "SELECT ClienteID, Nombre, DNI, Estado FROM Clientes";

            //creamos el comando lector, para poder leer la tabla entera//

            IDataReader lector = comando.ExecuteReader();

            //Creamos la lista de Clientes//
            List<Cliente> listaClientes = new List<Cliente>();


            //Recorrido con el lector//

            while (lector.Read())
            {
                Cliente cliente = new Cliente()
                {
                    ClienteID = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    DNI = lector.GetInt32(2),
                    Estado = lector.GetString(3)
                };

                listaClientes.Add(cliente);
            }

            //Cierre de conexion y devolvemos lista//
            conexion.Close();
            return listaClientes;

        }


        //--------------- GET BY ID ---------------//
        public Cliente GetByID(long ID)
        {

            //Pasaje de datos y valores a la query//
            string query = $"SELECT ClienteID, Nombre, DNI, Estado FROM Clientes WHERE ClienteID={ID}";

            // preparamos la conexion //
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando de texto// 
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = query;

            //Creamos el lector para leer los resultados//
            IDataReader lector = comando.ExecuteReader();

            //Definimos el cliente//
            Cliente clienteEncontrado = null;

            // Si el lector encuentra al cliente, se reenombra clienteEcontrado//
            if (lector.Read())
            {
                clienteEncontrado = new Cliente()
                {
                    ClienteID = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    DNI = lector.GetInt32(2),
                    Estado = lector.GetString(3)
                };
            }

            //Cuando termina la sentencia cerramos conexion y devolvemos el clienteEncontrado//
            conexion.Close();
            return clienteEncontrado;
        }


        //--------------- INSERT ---------------// 
        public bool Insert(Cliente nuevoC)
        {
            //creamos Query//
            string query = $"INSERT INTO Clientes (Nombre, DNI) VALUES ('{nuevoC.Nombre}', {nuevoC.DNI});";

            //preparamos la conexion//
            IDbConnection conexion = this.PrepararConexion();

            //creamos un comando de texto oara la query//
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = query;

            //ejecucion del comando//
            int filasAfectadas = comando.ExecuteNonQuery();

            //cierre de conexion//
            conexion.Close();

            return filasAfectadas > 0;

        }

        //--------------- UPDATE ---------------//
        public void Update(long ID, string Nombre)
        {
            //pasaje de datos y valores a la query//

            string query = $"UPDATE Clientes SET Nombre = '{Nombre}' WHERE ClienteID = {ID} AND Estado ='Activo';";

            //preparamos la conexion//
            IDbConnection conexion = this.PrepararConexion();

            //creamos un comando de texto para la query//
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = query;
            //ejecucion//
            comando.ExecuteNonQuery();

            //cierre de conexion//
            conexion.Close();

        }

        //--------------- DELETE ---------------//
        public bool Delete(long ID)
        {
            //Con la consulta SQL hacemos un soft delete mediante un UPDATE//

            //pase de datos y valores a la query//

            string query = $"UPDATE Clientes SET Estado = 'Inactivo' WHERE ClienteID = {ID}";

            //preparamos la conexion//
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = conexion.CreateCommand();

            // Le agregamos el texto al comando
            command.CommandText = query;

            int filasAfectadas = command.ExecuteNonQuery();

            //cierre de conexion y devuelve true si hay cambios//
            conexion.Close();
            return filasAfectadas > 0;

        }
    }
}
