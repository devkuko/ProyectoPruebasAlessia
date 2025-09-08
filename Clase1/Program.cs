Coche coche1 = new Coche(1, 120);

//coche1.id = 100;
Console.WriteLine(coche1.getId());
Console.WriteLine(coche1.ToString());

coche1.setId(100);

Console.WriteLine(coche1.getId());

modificarCoche(coche1);

Console.WriteLine(coche1.getId());

void modificarCoche(Coche c1)
{
    c1.setId(500);
}

int[] numeros = { 1, 2, 3 };
Console.WriteLine("Antes de CambiarArray: " + string.Join(", ", numeros));
CambiarArray(new int[] { 1, 2, 3 });
Console.WriteLine("Después de CambiarArray: " + string.Join(", ", numeros));


void CambiarArray(int[] numeros) // paso por referencia
{
    numeros[0] = 999; // modifica el array original

}



int numero = 5;
Console.WriteLine("Antes de CambiarValor: " + numero);
CambiarValor(numero);
Console.WriteLine("Después de CambiarValor: " + numero);

void CambiarValor(int numero)  //paso por valor
{
    numero = 999; // solo se cambia la copia
}

//Coche coche2 = coche1; // ref  posicion de memoria
Coche coche2 = new Coche(2, 120);

Coche coche3 = new Coche();
coche3.setId(3);
