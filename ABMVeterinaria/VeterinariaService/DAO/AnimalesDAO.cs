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
    public class AnimalesDAO : ConexionDAO
    {
        //----------------------------------- FUNCIONES DAO  -----------------------------------//

        //--------------- GET ALL ---------------// 
        public List<Animal> GetAll()
        {
            // Creamos conexion llamando a la funcion de preparar//
            using (IDbConnection conexion = this.PrepararConexion())
            {

                // Creamos un comando de texto//
                IDbCommand comando = conexion.CreateCommand();

                // Insertamos el string de la query //
                comando.CommandText = "SELECT AnimalID, Nombre, Peso, Edad, ClienteDNI, EspecieID, Estado FROM Animales";

                // Creamos el comando lector, para poder leer la tabla entera //
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
                        ClienteDNI = lector.GetInt32(4),
                        EspecieID = lector.IsDBNull(5) ? 0 : lector.GetInt32(5),
                        Estado = lector.GetString(6),
                    };

                    listaAnimales.Add(animal);
                }

                return listaAnimales;
            }

        }


        //--------------- GET BY ID ---------------//
        public Animal GetByID(long ID)
        {

            //Pasaje de datos y valores a la query//
            string query = $"SELECT AnimalID, Nombre, Peso, Edad, ClienteDNI, EspecieID, Estado FROM Animales WHERE AnimalID={ID}";

            // Preparamos la conexion
            using (IDbConnection conexion = this.PrepararConexion())
            {

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
                        ClienteDNI = lector.GetInt32(4),
                        EspecieID = lector.GetInt32(5),
                        Estado = lector.GetString(6),
                    };
                }


                return animalEncontrado;
            }

        }


        //--------------- INSERT ---------------// 
        public bool Insert(Animal nuevoA)
        {

            // Si no se proporciona el EspecieID lo ajustamos al valor por defecto
            if (nuevoA.EspecieID == 1)
            {
                nuevoA.EspecieID = 1;
            }

            //creamos Query//
            string query = $"INSERT INTO Animales (Nombre, Peso, Edad, ClienteDNI, EspecieID) VALUES ('{nuevoA.Nombre}', {nuevoA.Peso}, {nuevoA.Edad}, {nuevoA.ClienteDNI}, {nuevoA.EspecieID})";

            using (IDbConnection conexion = this.PrepararConexion())
            {
                // Creamos un comando de texto oara la query//
                IDbCommand comando = conexion.CreateCommand();

                // Insertamos la query al comando//
                comando.CommandText = query;

                // Ejecucion del comando//
                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;
            }

        }

        //--------------- UPDATE ---------------//
        public void Update(long ID, string nombre, decimal peso, int edad, long clienteDNI, long especieID)
        {
            //pasaje de datos y valores a la query//
            string query = $"UPDATE Animales SET Nombre = '{nombre}', Peso = {peso}, Edad = {edad}, ClienteDNI = {clienteDNI}, EspecieID = {especieID} WHERE AnimalID = {ID} AND Estado = 'Vivo';";

            // Preparmaos la conexion
            using (IDbConnection conexion = this.PrepararConexion())
            {
                //creamos un comando de texto para la query//
                IDbCommand comando = conexion.CreateCommand();

                comando.CommandText = query;
                //ejecucion//
                comando.ExecuteNonQuery();

                //cierre de conexion//
                conexion.Close();
            }
        }

        //--------------- DELETE ---------------//
        public bool Delete(long ID)
        {
            //Con la consulta SQL hacemos un soft delete mediante un UPDATE//

            //pase de datos y valores a la query//

            string query = $"UPDATE Animales SET Estado = 'Difunto' WHERE AnimalID = {ID}";

            using (IDbConnection conexion = this.PrepararConexion())
            {

                // Creamos el comando 
                IDbCommand comando = conexion.CreateCommand();

                // Le agregamos el texto al comando
                comando.CommandText = query;

                // Ejecutamos la sentencias
                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;
            }

        }

        //--------------- REPORTE PRINCIPAL ---------------//
        public DataTable GetReportePrincipal(int edadMin, int edadMax)
        {
            string query = "SELECT e.Nombre AS Especie, MIN(a.Peso) AS PesoMinimo, " +
               "MAX(a.Peso) AS PesoMaximo, CAST(AVG(a.Peso) AS DECIMAL(10,2)) AS PesoPromedio " +
               "FROM Animales a JOIN Especies e ON a.EspecieID = e.EspecieID " +
               $"WHERE a.Edad BETWEEN {edadMin} AND {edadMax} " +
               "GROUP BY e.Nombre;";

            using (IDbConnection conexion = this.PrepararConexion())
            {

                //Creamos el comando//
                var comando = conexion.CreateCommand();

                // Le pasamos la query al comando//
                comando.CommandText = query;

                // Creamos el ADAPTADOR//
                SqlDataAdapter adaptador = new SqlDataAdapter((SqlCommand)comando);

                // Creamos la DataTable//
                DataTable dt = new DataTable();

                // Llenamos con los valores del ADAPTOR a la DataTable//
                adaptador.Fill(dt);

                // Devolvemos la DataTable
                return dt;
            }



        }

        //--------------- REPORTE SECUNDARIO ---------------//
        public DataTable GetReporteSecundario()
        {
            string query = "SELECT " +
                           "    c.Nombre AS Cliente, " +
                           "    COUNT(a.AnimalID) AS CantidadAnimales " +
                           "FROM " +
                           "    Animales a " +
                           "JOIN " +
                           "    Clientes c ON a.ClienteDNI = c.DNI " +
                           "GROUP BY " +
                           "    c.Nombre " +
                           "ORDER BY " +
                           "    CantidadAnimales ASC;";

            using (IDbConnection conexion = this.PrepararConexion())
            {
                //Creamos el comando//
                var comando = conexion.CreateCommand();

                // Le pasamos la query al comando//
                comando.CommandText = query;

                // Creamos el ADAPTADOR//
                SqlDataAdapter adaptador = new SqlDataAdapter((SqlCommand)comando);

                // Creamos la DataTable//
                DataTable dt = new DataTable();

                // Llenamos con los valores del ADAPTOR a la DataTable//
                adaptador.Fill(dt);

                // Devolvemos la DataTable
                return dt;
            }



        }



    }
}
