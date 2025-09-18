using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefugioAnimales
{
    // 🔹 HERENCIA: Perro hereda de Animal
    class Perro : Animal
    {
        public string Raza { get; set; }

        public Perro(string nombre, int edad, string raza)
            : base(nombre, edad)
        {
            Raza = raza;
        }

        // 🔹 POLIMORFISMO
        public override void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Guau guau!");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Perro - Nombre: {Nombre}, Edad: {Edad}, Raza: {Raza}");
        }
    }
}
