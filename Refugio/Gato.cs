using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefugioAnimales
{
    // 🔹 HERENCIA: Gato hereda de Animal
    class Gato : Animal
    {
        public string Color { get; set; }

        public Gato(string nombre, int edad, string color)
            : base(nombre, edad)
        {
            Color = color;
        }

        // 🔹 POLIMORFISMO
        public override void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Miau miau!");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Gato - Nombre: {Nombre}, Edad: {Edad}, Color: {Color}");
        }
    }
}
