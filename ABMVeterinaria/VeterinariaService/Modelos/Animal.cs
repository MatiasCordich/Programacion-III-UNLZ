﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaService.Modelos
{
    public class Animal
    {
        // Atributos
        public long AnimalID { get; set; }
        public string Nombre { get; set; }
        public decimal Peso { get; set; }
        public int Edad { get; set; }
        public long ClienteID { get; set; }
        public long EspecieID { get; set; }


        //creamos el constructor de Animal//
        public Animal(string nombre, decimal peso, int edad, long clienteID, long especieID)
        {
            Nombre = nombre;
            Peso = peso;
            Edad = edad;
            ClienteID = clienteID;
            EspecieID = especieID;
        }

        //constructor vacio para dar de alta un Animal desde DB//
        public Animal()
        {

        }
    }
}