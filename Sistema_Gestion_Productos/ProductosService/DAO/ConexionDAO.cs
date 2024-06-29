using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosService.DAO
{
    public class ConexionDAO
    {
        //------ Constante - URL de la conexion ------//
        private const string CONEXION_URL = "server=;Database=;Integrated Security=true";

        //------ Funcion - Prepar la conexion con la DDBB ------//
        protected IDbConnection PrepararConexion()
        {
            SqlConnection conexion = new SqlConnection(CONEXION_URL);

            conexion.Open();

            return conexion;
        }
    }
}
