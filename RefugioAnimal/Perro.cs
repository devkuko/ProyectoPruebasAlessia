using System;

namespace RefugioAnimal
{
    internal class Perro : Animal
    {
        public string Raza { get; set; }

        public Perro(string nombre, int edad, string sexo, string raza) 
            : base(nombre, edad, sexo)
        {
            Raza = raza;
        }

        public override void MonstrarInformacion()
        {
            Console.WriteLine($"Hola soy {Nombre}, tengo {Edad} años, soy un/una {Sexo} y soy de raza {Raza}");
        }

        public override void EmitirSonido()
        {
            Console.WriteLine($"{Nombre} dice bauuu");
        }
    }
}
