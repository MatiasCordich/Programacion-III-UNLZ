using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.Modelos
{
    public class Animal
    {
        //--------------- ATRIBUTOS ---------------//
        public long AnimalID { get; set; }
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public int Edad { get; set; }
        public long ClienteDNI { get; set; }
        public long EspecieID { get; set; }
        public string Estado { get; set; }


        //--------------- CONSTRUCTOR ANIMAL ---------------//
        public Animal(string nombre, decimal peso, int edad, long clienteID, long especieID)
        {
            Nombre = nombre;
            Peso = peso;
            Edad = edad;
            ClienteDNI = clienteID;
            EspecieID = especieID;
        }

        //--------------- CONSTRUCTOR VACIO PARA LA DDBB ---------------//
        public Animal()
        {

        }
    }
}
