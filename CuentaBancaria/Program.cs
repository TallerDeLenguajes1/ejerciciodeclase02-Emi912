using System;

namespace CuentaBancaria
{
    public enum TipoExtraccion
    {
        CajeroHumano = 1,
        CajeroAutomatico = 2
    }
    class Cuenta
    {
        protected static int fondos;
        public virtual void Insercion(int monto)
        {

        }

        public virtual void Extraccion(int monto, TipoExtraccion num){


        }
        
    }
 
    class CajaAhorro : Cuenta
    {
       
        public override void Insercion(int monto)
        {
            Console.WriteLine("Has hecho una insercion de " + monto + "a caja de ahorro");
             fondos += monto;
        }

        public override void Extraccion(int monto, TipoExtraccion num)
        {
            if (fondos - monto >= 0)
            {
                if (TipoExtraccion.CajeroHumano == num)
                {
                    Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Humano");
                    fondos -= monto;
                }
                else
                {
                    if (monto <= 10000)
                    {
                        Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Automatico");
                        fondos -= monto;
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
    class CuentaCorrienteDolares : Cuenta
    {
        
     
        public override void Insercion(int monto)
        {
            Console.WriteLine("Has hecho una insercion de " + monto + "a Cuenta corriente dolares");
            fondos += monto;
        }

        public override void Extraccion(int monto, TipoExtraccion num)
        {
            if (TipoExtraccion.CajeroHumano == num)
            {
                Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Humano");
                fondos -= monto;
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

    class CuentaCorrientePesos : Cuenta
    {

      
        public override void Insercion(int monto)
        {
            Console.WriteLine("Has hecho una insercion de " + monto + "A Cuenta corriente pesos");
            fondos += monto;
        }

        public override void Extraccion(int monto, TipoExtraccion num)
        {
            if (fondos > -5000)
            {
                if (TipoExtraccion.CajeroAutomatico == num)
                {
                    Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Humano");
                    fondos -= monto;
                }
                else
                {
                    if (monto < 20000)
                    {
                        Console.WriteLine($"Has hecho una extraccion de {monto} por Cajero Automatico");
                        fondos -= monto;
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
    class Program
    {
      
        static void Main(string[] args)
        {
           
            Cuenta cajaAhorro = new CajaAhorro();
            Cuenta cuentaDolares = new CuentaCorrienteDolares();
            Cuenta cuentaPesos = new CuentaCorrientePesos();

            cajaAhorro.Insercion(50000);
            cuentaDolares.Insercion(50000);
            cuentaPesos.Insercion(50000);

            cuentaPesos.Extraccion(1000, TipoExtraccion.CajeroAutomatico);
        }
    }
}
