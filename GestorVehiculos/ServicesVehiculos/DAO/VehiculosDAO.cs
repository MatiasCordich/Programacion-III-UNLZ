using ServicesVehiculos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesVehiculos.DAO
{
    public class VehiculosDAO
    {
        // Preparamos la conexion 
        private IDbConnection prepararConexion() { 
           
            // Generamos la URL de nuestra conexion 
            string connectionString = "server=MATIAS\\SQLEXPRESS01;Database=ConcesionariaPurin;Integrated Security=true";

            // Generamos la conexión 
            SqlConnection connection = new SqlConnection(connectionString);

            // Abrimos la conexion
            connection.Open();

            // Devolvemos la conexion
            return connection;
        }

        // Funcion para traer toda la informacion de la DDBB (GETALL)
        public List<Vehiculo> getAll()
        {
            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.prepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos texto al comando
            command.CommandText = " SELECT ID, PATENTE, TIPO_ID, VELOCIDAD FROM VEHICULOS";

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer todo de nuestra tabla
            IDataReader lector = command.ExecuteReader();

            // Creamos nuestra Lista de tipo Vehiculo
            List<Vehiculo> listadin = new List<Vehiculo>();

            // Vamos a recorrer la respuesta de nuestro LECTOR
            while (lector.Read())
            {
                // Por cada dato leido del LECTOR creo un nuevo vehiculo
                Vehiculo vehiculin = new Vehiculo()
                {
                    id = lector.GetInt32(0),
                    patente = lector.GetString(1),
                    tipo_id = lector.GetInt32(2),
                    velocidad = lector.GetDecimal(3)
                };

                // Cada vehiculo creado lo agrego a la lista
                listadin.Add(vehiculin);
            }

            // Una vez realizado la consulta cierro la conexion y devuelvo la lista
            connection.Close();
            return listadin;
        }

        // Funcion para INSERTAR y guardar informacion a la DDBB (INSERT)
        public void insert(Vehiculo newV)
        {
            // Hacemoes el pase de datos y valores de newV a la QUERY
            string query = $"INSERT INTO VEHICULOS (PATENTE, TIPO_ID, VELOCIDAD) VALUES('{newV.patente}',{newV.tipo_id},{newV.velocidad})";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection connection = this.prepararConexion();

            // Creamos el comando 
            IDbCommand command = connection.CreateCommand();

            // Le agregamos el texto al comando
            command.CommandText = query;

            // Ejecutamos el comando 
            command.ExecuteNonQuery();

            // Una vez realizado la sentencia cerramos conexion 
            connection.Close();
        }
    }
}
