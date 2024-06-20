using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraConexion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Cremaos la URL para la conexion a la DB
            string connectionString = "Server=;" + "Database=;" + "Integrated Security=True;";
            
            // Establecemos la conexion
            SqlConnection connection = new SqlConnection(connectionString);

            // Abrimos la conexion
            connection.Open();

            // Creamos la variable para crear nuestras querys
            var command = connection.CreateCommand();

            // Creamos el comando para insertar un Usuario
            command.CommandText = "INSERT INTO USERS (NAME, PASSWORD) " + " VALUES('user01', 'password1');";

            // Intentanmos ejecutar la query
            try
            {
                command.ExecuteNonQuery();
            }catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }

            // Creamos el comando para leer los registros
            SqlCommand commandRead = connection.CreateCommand();

            // Creamos el string que contiene la sentencia de SQL
            commandRead.CommandText = @"
                SELECT ID, NAME
                FROM USERS
                ORDER BY ID
                ";

            // Ejectumos la sentencia mediante un 'cursor'
            SqlDataReader cursor = commandRead.ExecuteReader();

            // Ejecutamos el comando
            cursor.Read();
        }
    }
}
