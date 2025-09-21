using System;
using RefugioAnimal;

namespace RefugioAnimal
{ 
    class Program
    {
    public static void Main(string[] args)
    {
        Refugio refugio = new Refugio();

        Gato gato1 = new Gato("Michi", 2, "Macho", "Naranja");
        Perro perro1 = new Perro("Firulais", 3, "Macho", "Labrador");

        refugio.AgregarAnimal(gato1);
        refugio.AgregarAnimal(perro1);

        refugio.ListarAnimales();
    }

    }
    
}