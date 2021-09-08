using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    class CuentaCorrientePesos
    {
        private int Fondos;
        public enum TipoExtraccion
        {
            CajeroHumano = 1,
            CajeroAutomatico = 2
        }
        public void Insercion(int monto)
        {
            Console.WriteLine("Has hecho una insercion de " + monto + "A Cuenta corriente pesos");
            Fondos += monto;
        }

        public void Extraccion(int monto, TipoExtraccion num)
        {
            if (Fondos > -5000)
            {
                if (TipoExtraccion.CajeroHumano == num)
                {
                    Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Humano");
                    Fondos -= monto;
                }
                else
                {
                    if (monto < 20000)
                    {
                        Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Automatico");
                        Fondos -= monto;
                    }
                    else
                    {
                        Console.WriteLine("No se puede extraer mas de 20000 en Cajero Automatico");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("No hay Fondos!");
            }
           
           
        }

    }
}
