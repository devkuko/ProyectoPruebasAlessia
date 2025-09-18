using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Coche : ITransporte
    {
        public void Arrancar()
        {
            Console.WriteLine(" El coche arranca con la llave.");
        }

        public void Detener()
        {
            Console.WriteLine(" El coche se detiene usando los frenos.");
        }


        public void AbrirPuerta()
        {
            Console.WriteLine("abrimos la puerta");
        }
    }
}
