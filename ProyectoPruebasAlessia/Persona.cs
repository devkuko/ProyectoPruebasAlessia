namespace ProyectoPersonaHerencia
{
    // Clase base
    public class Persona
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método
        public virtual void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
        }
    }
}
