using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    class CajaAhorro
    {
        private int Fondos;
        public enum TipoExtraccion
        {
            CajeroHumano = 1,
            CajeroAutomatico = 2
        }
        public void Insercion(int monto)
        {
            Console.WriteLine("Has hecho una insercion de " + monto + "a caja de ahorro");
            Fondos += monto;
        }

        public void Extraccion(int monto, TipoExtraccion num)
        {
            if (Fondos - monto >= 0)
            {
                if (TipoExtraccion.CajeroHumano == num)
                { 
                    Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Humano");
                    Fondos -= monto;
                }
                else
                {
                    if (monto <= 10000)
                    {
                        Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Automatico");
                        Fondos -= monto;
                    }
                    else
                    {
                        Console.WriteLine("Solso se puede extraer hasta 10000 por Cajero Automatico");
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("No hay fondos");
            }
            
        }



    }
}
