namespace PooIntro.Herencia
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public void Arrancar() => Console.WriteLine($"{Marca} está arrancando...");
    }

    public class Coche : Vehiculo
    {
        public int Puertas { get; set; }
    }

    public class Moto : Vehiculo
    {
        public bool TieneSidecar { get; set; }
    }
}
