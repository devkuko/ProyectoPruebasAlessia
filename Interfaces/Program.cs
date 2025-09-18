class Program
{
    static void Main(string[] args)
    {
        ITransporte[] transportes = new ITransporte[]
        {
            new Coche(),
            new Bicicleta()
        };

        foreach (var transporte in transportes)
        {
            transporte.Arrancar();
            transporte.Detener();
            Console.WriteLine("--------------------");
        }
    }
}