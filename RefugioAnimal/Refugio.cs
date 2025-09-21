using System; 

namespace RefugioAnimal
{
    class Refugio
    {
        private List<Animal> ListaAnimales = new List<Animal>();

        public void AgregarAnimal(Animal animal)
        {
            ListaAnimales.Add(animal);
        }

        public void ListarAnimales()
        {
            foreach (var animal in ListaAnimales)
            {
                Console.WriteLine("Animales listos para adopcio en el refugio:");
                animal.MonstrarInformacion();
                animal.EmitirSonido();
            }
        }
    }
    
}
