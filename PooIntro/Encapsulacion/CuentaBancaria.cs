namespace PooIntro.Encapsulacion
{
    public class CuentaBancaria
    {
        // Campo privado (oculto al exterior)
        private decimal saldo;

        // Propiedad pública con control
        public decimal Saldo
        {
            get { return saldo; }
            private set { saldo = value; } // Solo se puede modificar desde dentro
        }

        public CuentaBancaria(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
                Saldo += cantidad;
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0 && cantidad <= Saldo)
                Saldo -= cantidad;
        }
    }
}
