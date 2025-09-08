
public class Coche
{
    private int id;
    public int velocidadMaxima;
    public const double PI = 3.14;

    public Coche(int id, int v2) //constructor 1
    {
        this.id = id;
        this.velocidadMaxima = v2;
    }

    public Coche(int id) //constructor 2
    {
        this.id = id;
    }

    public Coche() //constructor 3
    {
        this.velocidadMaxima = 120;
    }


    public int GetVelocidadmaximaPermitida()
    {
        return this.velocidadMaxima + 20;
    }

    public void setId(int id)
    {
        this.id = id;
    }
    public int getId()
    {
        return this.id;
    }

}
