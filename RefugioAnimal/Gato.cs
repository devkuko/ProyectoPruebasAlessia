using System;

namespace RefugioAnimal
{
    internal class Gato : Animal
    {
        public string Color { get; set; }
        public Gato(string nombre, int edad, string sexo, string color) 
            : base(nombre, edad, sexo)
        {
            Color = color;
        }
        public override void MonstrarInformacion()
        {
            Console.WriteLine($"Hola soy {Nombre}, tengo {Edad} años, soy un/una {Sexo} y soy de color {Color}");
        }
        public override void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} dice miauuu");
        }
    }
}
