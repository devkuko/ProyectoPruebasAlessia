using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugioAnimales
{
    class Refugio
    {
        private List<Animal> animales = new List<Animal>();

        public void AgregarAnimal(Animal animal)
        {
            animales.Add(animal);
            Console.WriteLine($"{animal.Nombre} ha sido agregado al refugio.");
        }

        public void MostrarAnimales()
        {
            Console.WriteLine("\nLista de animales en el refugio:");
            foreach (Animal animal in animales)
            {
                animal.MostrarInformacion();
                animal.EmitirSonido();
            }
        }
    }
}
