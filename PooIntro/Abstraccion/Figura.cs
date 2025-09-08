namespace PooIntro.Abstraccion
{
    public abstract class Figura
    {
        public abstract double CalcularArea();
    }

    public class Circulo : Figura
    {
        public double Radio { get; set; }
        public Circulo(double radio) => Radio = radio;

        public override double CalcularArea() => Math.PI * Radio * Radio;
    }

    public class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public override double CalcularArea() => Ancho * Alto;
    }
}
