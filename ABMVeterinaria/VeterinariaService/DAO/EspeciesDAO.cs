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
    public class EspeciesDAO
    {
        //----------------------------------- PREPARAR CONEXION -----------------------------------
        private IDbConnection PrepararConexion()
        {
            string conexionURL = "server=MATIAS\\SQLEXPRESS01;Database=veterinaria_db;Integrated Security=true";

            SqlConnection conexion = new SqlConnection(conexionURL);

            conexion.Open();

            return conexion;
        }

        //----------------------------------- FUNCIONES DAO  -----------------------------------

        //--------------- GET ALL ---------------
        public List<Especie> GetAll()
        {
            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand comando = conexion.CreateCommand();

            // Le agregamos texto al comando
            comando.CommandText = "SELECT EspecieID, Nombre, EdadMadurez, PesoPromedio FROM Especies";

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer todo de nuestra tabla
            IDataReader lector = comando.ExecuteReader();

            //Generamos la lista de especies
            List<Especie> listaEspecies = new List<Especie>();

            // Recorremos la respuesta del lector
            while (lector.Read())
            {
                // Por cada dato leido del LECTOR vamos a crear nuestros objetos de tipo Especie
                Especie especie = new Especie()
                {
                    EspecieID = lector.GetInt32(0),
                    NombreEspecie = lector.GetString(1),
                    EdadMadurez = lector.GetInt32(2),
                    PesoPromedio = lector.GetDecimal(3)
                };
                //Agregamos cada Especie a la lista
                listaEspecies.Add(especie);

            }

            //Cerramos conexion y devolvemos la lista
            conexion.Close();

            return listaEspecies;

        }

        //--------------- GET BY ID --------------- 
        public Especie GetByID(long id)
        {
            // Hacemos el pase de datos y valores de newP a la QUERY
            string query = $"SELECT EspecieID, Nombre, EdadMadurez, PesoPromedio FROM Especies WHERE EspecieID= {id}";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand comando = conexion.CreateCommand();

            // Le agregamos el texto al comando
            comando.CommandText = query;

            // Creamos el LECTOR, va a ejecutar la sentencia que nos va a permitir leer los resultados de la sentencia
            IDataReader lector = comando.ExecuteReader();

            // Definimos la especie
            Especie especieEncontrada = null;

            // Si hay datos en el lector, lo volcamos al objeto especieEncontrada
            if (lector.Read())
            {
                especieEncontrada = new Especie()
                {
                    EspecieID = lector.GetInt32(0),
                    NombreEspecie = lector.GetString(1),
                    EdadMadurez = lector.GetInt32(2),
                    PesoPromedio = lector.GetDecimal(3),
                };
            }

            // Una vez realizado la sentencia cerramos conexion y devolvemos el resultado
            conexion.Close();

            return especieEncontrada;
        }

        //--------------- INSERT --------------- 
        public bool Insert(Especie nuevaE)
        {
            //Creamos la query
            string query = $"INSERT INTO Especies (Nombre, EdadMadurez, PesoPromedio) VALUES ('{nuevaE.NombreEspecie}', {nuevaE.EdadMadurez}, {nuevaE.PesoPromedio})";

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

            return filasAfectadas > 0;

        }

        //--------------- UPDATE ---------------
        public void Update(long id, string nombre, int edad, decimal peso)
        {

            // Hacemoes el pase de datos y valores que recibimos por parametros a la QUERY
            string query = $"UPDATE Especies SET Nombre = '{nombre}', " +
                                   $"EdadMadurez = {edad}, " +
                                   $"PesoPromedio = {peso} " +
                                   $"WHERE EspecieID = {id}";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand comando = conexion.CreateCommand();

            // Le agregamos el texto al comando
            comando.CommandText = query;

            // Ejecutamos la sentencia 
            comando.ExecuteNonQuery();

            // Cerramos la conexion
            conexion.Close();

        }
        //--------------- DELETE ---------------
        public void Delete(long id)
        {
            // Hacemoes el pase de datos y valores que recibimos por parametros a la QUERY
            string query = $"UPDATE Especies SET Estado = 'Inactivo' WHERE EspecieID = {id}";

            // Creamos la conexion llamando la funcion creada recientemente
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando 
            IDbCommand comando = conexion.CreateCommand();

            // Le agregamos el texto al comando
            comando.CommandText = query;

            // Ejecutamos la sentencia
            comando.ExecuteNonQuery();

            // Cerramos la conexion
            conexion.Close();

        }
    }
}
