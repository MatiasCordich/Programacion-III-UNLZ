using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesVehiculos.Models
{
    // No olvidar cambiar de INTERNAL a PUBLIC
    public class Vehiculo
    {
        // Atributos del modelo 
        public long id {  get; set; }
        public string patente { get; set; }
        public long tipo_id { get; set; }
        public decimal velocidad { get; set; }

        // Generamos el constructor de Vehiculo 
        public Vehiculo(string patente, long tipo_id, decimal velocidad)
        {
            this.patente = patente;
            this.tipo_id = tipo_id;
            this.velocidad = velocidad;
        }

        // Generamos el constructor vacio para agregar el Vehiculo a la DDBB
        public Vehiculo() { }
    }
}
