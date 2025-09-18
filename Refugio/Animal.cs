using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugioAnimales
{
    // 🔹 ABSTRACCIÓN
    public abstract class Animal
    {
        // 🔹 ENCAPSULACIÓN
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0)
                    edad = value;
                else
                    edad = 0;
            }
        }

        public Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Métodos abstractos
        public abstract void EmitirSonido();
        public abstract void MostrarInformacion();
    }
}
