namespace ProyectoPersonaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear objetos
            Persona persona1 = new Persona("Lucía", 30);
            Estudiante estudiante1 = new Estudiante("Carlos", 20, "Informática");
            Profesor profesor1 = new Profesor("María", 40, "Programación");

            // Usar métodos
            persona1.Presentarse();
            estudiante1.Presentarse();
            profesor1.Presentarse();

            // Polimorfismo en acción
            List<Persona> personas = new List<Persona> { persona1, estudiante1, profesor1 };

            Console.WriteLine("\n--- Lista de Personas (polimorfismo) ---");
            foreach (var p in personas)
            {
                Console.WriteLine(p.GetType());
                p.Presentarse(); // Se llama al método correspondiente según el tipo real
            }
        }
    }
}
