using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Bicicleta : ITransporte
    {
        public void Arrancar()
        {
            Console.WriteLine(" La bicicleta comienza a pedalear.");
        }

        public void Detener()
        {
            Console.WriteLine(" La bicicleta se detiene con los frenos de mano.");
        }
    }
}
