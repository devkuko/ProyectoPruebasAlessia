namespace PooIntro.Abstraccion
{
    public abstract class Figura
    {
        public abstract double CalcularArea() ;

    }

    public class Circulo : Figura
    {
        public double Radio { get; set; } // Propiedad
        public Circulo(double radio) => Radio = radio; // constructor

        public override double CalcularArea() => Math.PI * Radio * Radio; //funcion abstracta heredada de figura
    }

    public class Rectangulo : Figura
    {
        public double Ancho { get; set; } // propiedad
        public double Alto { get; set; }// propiedad

        public Rectangulo(double ancho, double alto)  //constructor
        {
            Ancho = ancho;
            Alto = alto;
        }

        public override double CalcularArea() => Ancho * Alto;  //funcion abstracta heredada de figura
    }
}
