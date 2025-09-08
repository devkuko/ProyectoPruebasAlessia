using PooIntro.Abstraccion;
using PooIntro.Encapsulacion;
using PooIntro.Herencia;
using PooIntro.Polimorfismo;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POOIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Encapsulación ---
            var cuenta = new CuentaBancaria(1000);
            cuenta.Depositar(500);
            cuenta.Retirar(200);
            Console.WriteLine($"Saldo actual: {cuenta.Saldo}");

            // --- Abstracción ---
            Figura f1 = new Circulo(3);
            Figura f2 = new Rectangulo(2, 5);
            Console.WriteLine($"Área círculo: {f1.CalcularArea()}");
            Console.WriteLine($"Área rectángulo: {f2.CalcularArea()}");

            // --- Herencia ---
            var coche = new Coche { Marca = "Ford", Puertas = 4 };
            coche.Arrancar();
            var moto = new Moto { Marca = "Yamaha", TieneSidecar = false };
            moto.Arrancar();

            // --- Polimorfismo ---
            List<Animal> animales = new List<Animal>
            {
                new Perro(),
                new Gato(),
                new Animal()
            };
            foreach (var animal in animales)
            {
                animal.Hablar();
            }
        }
    }
}
