namespace PooIntro.Polimorfismo
{
    public class Animal
    {
        public virtual void Hablar()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    public class Perro : Animal
    {
        public override void Hablar()
        {
            Console.WriteLine("Guau guau!");
        }
    }

    public class Gato : Animal
    {
        public override void Hablar()
        {
            Console.WriteLine("Miau miau!");
        }
    }
}
