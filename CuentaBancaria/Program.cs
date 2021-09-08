using System;

namespace CuentaBancaria
{
    class Program
    {
      
        static void Main(string[] args)
        {
           
        CajaAhorro cajaAhorro = new CajaAhorro();
            CuentaCorrienteDolares cuentaDolares = new CuentaCorrienteDolares();
            CuentaCorrientePesos cuentaPesos = new CuentaCorrientePesos();

            cajaAhorro.Insercion(50000);
            cuentaDolares.Insercion(50000);
            cuentaPesos.Insercion(50000);

            cuentaPesos.Extraccion(1000, CuentaCorrientePesos.TipoExtraccion.CajeroAutomatico);
        }
    }
}
