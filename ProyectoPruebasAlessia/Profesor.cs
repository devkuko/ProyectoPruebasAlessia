namespace POOIntro
{
	// Profesor tambi�n hereda de Persona
	public class Profesor : Persona
	{
		public string Asignatura { get; set; }

		public Profesor(string nombre, int edad, string asignatura)
			: base(nombre, edad)
		{
			Asignatura = asignatura;
		}

		public override void Presentarse()
		{
			Console.WriteLine($"Hola, soy el profesor {this.Nombre}, ense�o {this.Asignatura}.");
		}
	}
}
