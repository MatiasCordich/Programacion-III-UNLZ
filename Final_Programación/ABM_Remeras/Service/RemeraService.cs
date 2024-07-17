using ABM_Remeras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Remeras.Service
{
    public static class RemeraService
    {

        // -------------------- METODOS -------------------- //

        /// <summary>
        /// Calcula el precio promedio de las remeras que tengan talle L
        /// </summary>
        /// <param name="listaRemeras">Recibe por parametro una lista de tipo Remera</param>
        public static double CalcuarPromedioPrecioL(List<Remera> listaRemeras)
        {
            // Me devuelve una lista de las remeras con talle L
            var remerasL = listaRemeras.Where(remera => remera.Talle == "L");

            // Valido si hay remeras 
            if (remerasL.Any())
            {
                double promedioRemerasL = remerasL.Average(remera => remera.Precio);
                return promedioRemerasL;
            }
            else
            {
                return 0.00;
            }
        }

        /// <summary>
        /// Calcula la cantidad de remeras con talle XL que hay
        /// </summary>
        /// <param name="listaRemeras">Recibe por parametro una lista de tipo Remera</param>
        public static int CantidadRemerasXL(List<Remera> listaRemeras)
        {
            return listaRemeras.Count(remera => remera.Talle == "XL");
        }
    }
}
