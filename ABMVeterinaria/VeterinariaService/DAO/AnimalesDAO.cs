using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaService.Modelos;
using System.Net.Sockets;

namespace VeterinariaService.DAO
{
    public class AnimalesDAO
    {
        //----------------------------------- PREPARAR CONEXION -----------------------------------//
        private IDbConnection PrepararConexion()
        {
            string conexionURL = "server=MATIAS\\SQLEXPRESS01;Database=veterinaria_db;Integrated Security=true";

            SqlConnection conexion = new SqlConnection(conexionURL);

            conexion.Open();

            return conexion;
        }

        //----------------------------------- FUNCIONES DAO  -----------------------------------//

        //--------------- GET ALL ---------------// 
        public List<Animal> GetAll()
        {
            //creamos conexion llamando a la funcion de preparar//
            IDbConnection conexion = this.PrepararConexion();

            //creamos un comando de texto//
            IDbCommand comando = conexion.CreateCommand();

            //en base a la tabla Clientes, agregamos los atributos//
            comando.CommandText = "SELECT AnimalID, Nombre, Peso, Edad, ClienteID, EspecieID, Estado FROM Animales";

            //creamos el comando lector, para poder leer la tabla entera//

            IDataReader lector = comando.ExecuteReader();

            //Creamos la lista de Clientes//
            List<Animal> listaAnimales = new List<Animal>();

            //Recorrido con el lector//

            while (lector.Read())
            {
                Animal animal = new Animal()
                {
                    AnimalID = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Peso = lector.GetDecimal(2),
                    Edad = lector.GetInt32(3),
                    ClienteID = lector.GetInt32(4),
                    EspecieID = lector.IsDBNull(5) ? 0 : lector.GetInt32(5),
                    Estado = lector.GetString(6),
                };

                listaAnimales.Add(animal);
            }

            //Cierre de conexion y devolvemos lista//
            conexion.Close();
            return listaAnimales;

        }


        //--------------- GET BY ID ---------------//
        public Animal GetByID(long ID)
        {

            //Pasaje de datos y valores a la query//
            string query = $"SELECT AnimalID, Nombre, Peso, Edad, ClienteID, EspecieID, Estado FROM Animales WHERE AnimalID={ID}";

            // preparamos la conexion //
            IDbConnection conexion = this.PrepararConexion();

            // Creamos el comando de texto// 
            IDbCommand comando = conexion.CreateCommand();

            comando.CommandText = query;

            //Creamos el lector para leer los resultados//
            IDataReader lector = comando.ExecuteReader();

            //Definimos el cliente//
            Animal animalEncontrado = null;

            // Si el lector encuentra al cliente, se reenombra clienteEcontrado//
            if (lector.Read())
            {
                animalEncontrado = new Animal()
                {
                    AnimalID = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Peso = lector.GetDecimal(2),
                    Edad = lector.GetInt32(3),
                    ClienteID = lector.GetInt32(4),
                    EspecieID = lector.GetInt32(5),
                    Estado = lector.GetString(6),
                };
            }

            //Cuando termina la sentencia cerramos conexion y devolvemos el clienteEncontrado//
            conexion.Close();
            return animalEncontrado;
        }


        //--------------- INSERT ---------------// 
        public bool Insert(Animal nuevoA)
        {

            // Si no se proporciona el EspecieID lo ajustamos al valor por defecto
            if(nuevoA.EspecieID == 1)
            {
                nuevoA.EspecieID = 1;
            }

            //creamos Query//
            string query = $"INSERT INTO Animales (Nombre, Peso, Edad, ClienteID, EspecieID) VALUES ('{nuevoA.Nombre}', {nuevoA.Peso}, {nuevoA.Edad}, {nuevoA.ClienteID}, {nuevoA.EspecieID})";

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
        public void Update(long ID, string nombre, decimal peso, int edad, long clienteID, long especieID )
        {
            //pasaje de datos y valores a la query//

            string query = $"UPDATE Animales SET Nombre = '{nombre}', Peso = {peso}, Edad = {edad}, ClienteID = {clienteID}, EspecieID = {especieID} WHERE AnimalID = {ID} AND Estado = 'Vivo';";

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

            string query = $"UPDATE Animales SET Estado = 'Difunto' WHERE AnimalID = {ID}";

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
