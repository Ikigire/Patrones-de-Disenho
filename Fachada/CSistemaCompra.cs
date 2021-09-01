using System;
using System.Collections.Generic;
using System.Text;

namespace Subsistemas
{
    class CSistemaCompra
    {
        public bool Comprar()
        {
            string dato = "";

            Console.WriteLine("Introduce el número de tarjeta: ");
            dato = Console.ReadLine();

            if(dato == "12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago aceptado;");
                return true;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago rechazado;");
                return false;
            }

        }
    }

    class CSistemaAlmacen
    {
        private int cantidad; 
        public CSistemaAlmacen()
        {
            this.cantidad = 3;
        }

        public bool SacarAlmacen()
        {
            if (cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para envío");
                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible, espera ha que haya existencia");
                return false;
            }
        }
    }

    class CSistemaEnvio
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El producto está en camino");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
