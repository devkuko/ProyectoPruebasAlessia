using System.Globalization;

namespace RefugioAnimal
{
    internal abstract class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }

        private Guid IdInterno { get; }


        // Constructor 
        public Animal(string nombre, int edad, string sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            IdInterno = Guid.NewGuid();
        }

        // Metodo abstracto 
        public abstract void MonstrarInformacion();
        public abstract void EmitirSonido();


        // Metodo paa uso privado (staff)
        public string ObtemerIdInterno()
        {
            return IdInterno.ToString();
        }
    }
}



    
