using ProductosService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosService.DAO
{
    public class ProductosDAO : ConexionDAO
    {
        // ------------------------ Funciones - DAO ------------------------//

        //------ Funcion - GetAll ------//
        public List<Producto> GetAll()
        {
            using (IDbConnection connection = PrepararConexion())
            {
                // Query - Sentencia seleccionar todos los productos //
                string query = "SELECT ProductoID, Codigo, Descripcion, Valor, CategoriaID, Estado, Cantidad FROM Productos";

                // Lista - Lista de productos //
                List<Producto> listaProductos = new List<Producto>();

                // Comando - Creacion del comando SQL //
                IDbCommand command = connection.CreateCommand();

                // Inserccion - Insertamos la variable QUERY al comando //
                command.CommandText = query;

                // Lector - Ejecutamos la sentencia y creamos el lector //
                IDataReader reader = command.ExecuteReader();

                // Bucle - Si el lector tiene datos, vamos creando los objetos //
                while (reader.Read())
                {
                    Producto producto = new Producto()
                    {
                        ProductoID = reader.GetInt32(0),
                        Codigo = reader.GetString(1),
                        Descripcion = reader.GetString(2),
                        Valor = reader.GetDecimal(3),
                        CategoriaID = reader.GetInt32(4),
                        Estado = reader.GetString(5),
                        Cantidad = reader.GetInt32(6)
                    };

                    // Inserccion - Agregamos cada producto a la lista //
                    listaProductos.Add(producto);
                }

                // Resultado - Devolvemos el valor de la lista //
                return listaProductos;
            }

        }
        //------ Funcion - GetByID ------//
        public Producto GetProductoByID(int ID)
        {
            using (IDbConnection connection = PrepararConexion())
            {
                // Query - Sentencia seleccionar todos los productos //
                string query = $"SELECT ProductoID, Codigo, Descripcion, Valor, CategoriaID, Estado " +
               $"FROM Productos WHERE ProductoID = {ID}";

                // Comando - Creacion del comando SQL //
                IDbCommand command = connection.CreateCommand();

                // Inserccion - Insertamos la variable QUERY al comando //
                command.CommandText = query;

                // Lector - Ejecutamos la sentencia y creamos el lector //
                IDataReader reader = command.ExecuteReader();

                // Producto - Creamos el objeto que guardara el resultado del lector //
                Producto productoEncontrado = null;

                // Lector - Validacion del lector del resultado obtenido
                if (reader.Read())
                {
                    productoEncontrado = new Producto()
                    {
                        ProductoID = reader.GetInt32(0),
                        Codigo = reader.GetString(1),
                        Descripcion = reader.GetString(2),
                        Valor = reader.GetDecimal(3),
                        CategoriaID = reader.GetInt32(4),
                        Estado = reader.GetString(5)
                    };
                }

                // Resultado - Devolvemos el resultado //
                return productoEncontrado;

            }
        }
        //------ Funcion - Insert ------//
        public bool InsertProducto(Producto nuevoP)
        {
            using (IDbConnection connection = PrepararConexion())
            {
                // Query - Sentencia seleccionar todos los productos //
                string query = $"INSERT INTO Productos (Codigo, Descripcion, Valor, CategoriaID) " +
               $"VALUES ('{nuevoP.Codigo}', '{nuevoP.Descripcion}', {nuevoP.Valor}, {nuevoP.CategoriaID})";

                // Creamos un comando de texto oara la query//
                IDbCommand command = connection.CreateCommand();

                // Insertamos la query al comando//
                command.CommandText = query;

                // Ejecucion del comando//
                int rowsAffected = command.ExecuteNonQuery();

                // Resultado - Devolvemos el resultado //
                return rowsAffected > 0;

            }
        }
        //------ Funcion - Update ------//
        public void UpdateProducto(int ID, string codigo, string descripcion, decimal valor, int categoriaID, string estado)
        {
            using (IDbConnection connection = PrepararConexion())
            {
                // Query - Sentencia seleccionar todos los productos //
                string query = $"UPDATE Productos SET Nombre = '{codigo}', Descripcion = {descripcion}, Valor = {valor}, CategoriaID = {categoriaID}, Estado = '{estado}' " +
                $"WHERE ProductoID = {ID};";

                // Comando - creamos  un comando de texto para la query //
                IDbCommand command = connection.CreateCommand();

                // Insertamos la query al comando//
                command.CommandText = query;

                // Ejecucion - Ejecutamos el comando //
                command.ExecuteNonQuery();
            }
        }
        //------ Funcion - Delete ------//
        public bool DeleteProducto(int ID)
        {
            using (IDbConnection connection = PrepararConexion())
            {
                // Query - Sentencia seleccionar todos los productos //
                string query = $"UPDATE Productos SET Estado = 'Sin Stock' WHERE ProductoID = {ID}";

                IDbCommand comando = connection.CreateCommand();

                // Le agregamos el texto al comando
                comando.CommandText = query;

                // Ejecutamos la sentencias
                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;


            }
        }
    }
}
