// Programa Principal
using RefugioAnimales;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Refugio refugio = new Refugio();

        Perro perro1 = new Perro("Firulais", 3, "Labrador");
        Gato gato1 = new Gato("Misu", 2, "Negro");

        refugio.AgregarAnimal(perro1);
        refugio.AgregarAnimal(gato1);

        refugio.MostrarAnimales();

        Console.ReadLine();
    }
}