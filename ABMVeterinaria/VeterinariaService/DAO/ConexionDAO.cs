using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.DAO
{
    public class ConexionDAO
    {
        private const string CONEXION_URL = "server=;Database=;Integrated Security=true";

        // Funcion - Inicializar conexion
        protected IDbConnection PrepararConexion()
        {
            SqlConnection conexion = new SqlConnection(CONEXION_URL);

            conexion.Open();

            return conexion;
        }
    }
}
