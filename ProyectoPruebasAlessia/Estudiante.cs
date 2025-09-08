namespace POOIntro
{
    // Estudiante hereda de Persona
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, int edad, string carrera)
            : base(nombre, edad) // Llamamos al constructor de Persona
        {
            Carrera = carrera;
        }

        // Sobrescritura de método (Polimorfismo)
        public override void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre}, tengo {Edad} años y estudio {Carrera}.");
        }
    }
}
