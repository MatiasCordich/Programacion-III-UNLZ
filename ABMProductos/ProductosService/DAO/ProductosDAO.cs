using ProductosService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProductosService.DAO
{
    public class ProductosDAO
    {
        // Funcion para preparar la conexion
        private IDbConnection PrepararConexion()
        {
            // Generamos la URL de nuestra conexion 
            string connectionString = "";

            // Generamos la conexión 
            SqlConnection connection = new SqlConnection(connectionString);

            // Abrimos la conexion
            connection.Open();

            // Devolvemos la conexion
            return connection;
        }

        // Funciones del DAO (GETALL, GETBY, INSERT, UPDATE, DELETE)

        // GETALL
        public List<Producto> GetAll() {

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos texto al comando
            command.CommandText = "SELECT ID, NOMBRE, TIPO, PRECIO FROM PRODUCTOS";

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer todo de nuestra tabla
            IDataReader lector = command.ExecuteReader();

            // Creamos nuestra lista de productos
            List<Producto> listaProductos = new List<Producto>();

            // Recorremos la respuesta del lector
            while (lector.Read())
            {
                // Por cada dato leido del LECTOR vamos a crear nuestros objetos de tipo Prouducto
                Producto producto = new Producto()
                {
                    id = lector.GetInt32(0),
                    nombre = lector.GetString(1),
                    tipoProducto_id = lector.GetInt32(2),
                    precio = lector.GetDecimal(3)
                };

                // Agregamos cada producto a la lista
                listaProductos.Add(producto);
            }

            // Cerramos conexion y devolvemos la lista
            connection.Close();

            return listaProductos;

        }

        // GETBY
        public Producto GetByID(long id) {

            // Hacemos el pase de datos y valores de newP a la QUERY
            string query = $"SELECT ID, NOMBRE, TIPO, PRECIO FROM PRODUCTOS WHERE ID={id}";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos el texto al comando
            command.CommandText = query;

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer los resultados de la sentencia
            IDataReader lector = command.ExecuteReader();

            // Definimos el producto
            Producto productoEncontrado = null;

            // Si hay datos en el lector, lo volcamos al objeto productoEcontrado
            if (lector.Read())
            {
               productoEncontrado = new Producto()
               {
                   id=lector.GetInt32(0),
                   nombre = lector.GetString(1),
                   tipoProducto_id= lector.GetInt32(2),
                   precio= lector.GetDecimal(3)
               };
            }

            // Una vez realizado la sentencia cerramos conexion y devolvemos el resultado
            connection.Close();

            return productoEncontrado;
        }
 
        // INSERT
        public bool Insert(Producto newP) {

            // Hacemos el pase de datos y valores de newP a la QUERY
            string query = $"INSERT INTO PRODUCTOS (NOMBRE, TIPO, PRECIO) VALUES('{newP.nombre}',{newP.tipoProducto_id}, {newP.precio})";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos el texto al comando
            command.CommandText = query;

            // Ejecutamos el comando 
            int rowsAffected = command.ExecuteNonQuery();

            // Una vez realizado la sentencia cerramos conexion 
            connection.Close();

            // Retornamos true si una fila fue actualizada, false en caso contrario
            return rowsAffected > 0;

        }

        // UPDATE
        public bool Update(long id, string nombre, long tipoProducto_id, decimal precio ) {

            // Hacemoes el pase de datos y valores que recibimos por parametros a la QUERY
            string query = $"UPDATE PRODUCTOS SET NOMBRE = '{nombre}', TIPO = {tipoProducto_id}, PRECIO = {precio} WHERE ID = {id}";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos el texto al comando
            command.CommandText = query;

            // Ejecutamos la sentencia 
            int rowsAffected = command.ExecuteNonQuery();

            // Cerramos la conexion
            connection.Close ();

            // Retornamos true si hubo cambios en las filas, false en caso contrario
            return rowsAffected > 0;

        }

        // DELETE
        public bool Delete(long id)
        {

            // Definimos la consulta SQL para la eliminación
            // Hacemoes el pase de datos y valores que recibimos por parametros a la QUERY
            string query = $"DELETE FROM PRODUCTOS WHERE ID = {id}";

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
