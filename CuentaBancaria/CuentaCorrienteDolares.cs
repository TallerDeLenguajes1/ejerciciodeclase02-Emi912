using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    class CuentaCorrienteDolares
    {
        private int Fondos;
        public enum TipoExtraccion
        {
            CajeroHumano = 1,
            CajeroAutomatico = 2
        }
        public void Insercion(int monto)
        {
            Console.WriteLine("Has hecho una insercion de " + monto + "a Cuenta corriente dolares");
            Fondos += monto;
        }

        public void Extraccion(int monto, TipoExtraccion num)
        {
            if (TipoExtraccion.CajeroHumano == num)
            {
                Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Humano");
                Fondos -= monto;
            }
            else
            {
                if (monto < 200)
                {
                    Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Automatico");
                }
                else
                {
                    Console.WriteLine("Solo se puede extraer hasta 200 Dolares en Cajero Automatico");
                }
              

            }
        }

    }
}
